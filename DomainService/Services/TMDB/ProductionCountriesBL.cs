using AutoMapper;
using DataAccess.RESTServices.TheMovieDB.Interfaces;
using DomainService.Contracts.TMDB;
using DomainService.Services.BaseBL;
using Entities.Base;
using Entities.TMDB.Movies;
using Repository.Contracts.TMDB;

namespace DomainService.Services.TMDB
{
	public class ProductionCountriesBL : BaseBL<ProductionCountry>, IProductionCountriesBL
	{
		private readonly IProductionCountriesDA prodCountDA;
		private readonly IMoviesProductionCountriesBL movieProdCountriesBL;
		private readonly IQueryServiceTMDB queryService;
		private readonly IMapper mapper;

		public ProductionCountriesBL(IProductionCountriesDA iProdCountDA, IQueryServiceTMDB iQqueryService, IMapper iMapper, 
			IMoviesProductionCountriesBL iMovieProdCountriesBL)
			 : base((Repositories.BaseDA.IBaseDA<ProductionCountry>)iProdCountDA)
		{
			prodCountDA = iProdCountDA;
			mapper =iMapper;
			queryService = iQqueryService;
			movieProdCountriesBL = iMovieProdCountriesBL;
		}

		public bool AlreadyExistsByIso(string iso31661) => prodCountDA.AlreadyExistsByIso(iso31661);

		public ProductionCountry GetByIso(string iso31661) => prodCountDA.GetByIso(iso31661);

		public ProductionCountry Update(ProductionCountry productionCountry)
		{
			if (!prodCountDA.AlreadyExistsById(productionCountry.Id))
				throw new Exception("No existe el País de Producción especificada en la base de datos");

			ProductionCountry prodCountOnDb = base.GetById(productionCountry.Id);
			prodCountOnDb.IdTMDB = productionCountry.IdTMDB;
			prodCountOnDb.Iso31661 = productionCountry.Iso31661;
			prodCountOnDb.Name = productionCountry.Name;
			prodCountOnDb.RowState = RowState.Modified;
			return base.Save(prodCountOnDb);
		}

		public ProductionCountry Create(ProductionCountry productionCountry)
		{
			ProductionCountry productionCountryAdded = new();

			if (!prodCountDA.AlreadyExistsByName(productionCountry.Name))
			{
				productionCountry.RowState = RowState.Added;
				productionCountryAdded = base.Save(productionCountry);
			}
			else
				throw new Exception("Ya existe un País de Producción con ese nombre");

			return productionCountryAdded;
		}

		public ProductionCountry Delete(long Id)
		{
			bool hasMovies = prodCountDA.HasMoviesAssociated(Id);
			if (hasMovies)
				throw new Exception("El País de Producción tiene películas asociadas y no se puede eliminar");
			else
			{
				var prodCountOnDb = base.GetById(Id);
				prodCountOnDb.RowState = RowState.Deleted;
				return base.Save(prodCountOnDb);
			}
		}

		public void SaveAssociatedProdCounts(long movieId, List<ProductionCountry> prodCounts)
		{
			if (prodCounts == null)
				prodCounts = new();

			List<MovieProductionCountry> productionCountries = new();
			if (prodCounts != null)
			{
				for (int i = 0; i <= prodCounts.Count() - 1; i++)
				{
					ProductionCountry country = prodCounts[i];
					if (AlreadyExistsByIso(country.Iso31661))
					{
						ProductionCountry countryOnDb = GetByIso(country.Iso31661);
						prodCounts[i].Id = countryOnDb.Id;
					}
					else
					{
						var countryToCreate = new ProductionCountry()
						{
							Iso31661 = country.Iso31661,
							Name = country.Name,
						};
						var companyAdded = Create(countryToCreate);
						prodCounts[i].Id = companyAdded.Id;
					}
				}
			}

			foreach (var prodCount in prodCounts)
			{
				MovieProductionCountry prodCountry = new()
				{
					MovieID = movieId,
					ProductionCountryID = prodCount.Id
				};
				productionCountries.Add(prodCountry);
			}
			movieProdCountriesBL.Save(movieId, productionCountries);
		}

		public async Task<List<ProductionCountry>> UpdateCountriesFromTmdb()
		{
			List<ProductionCountry> countriesUpdated = new();
			var countriesOnTmdb = await queryService.GetProductionCountries();

			for (int i = 0; i <= countriesOnTmdb.Count() - 1; i++)
			{
				try
				{
					if (!prodCountDA.AlreadyExistsByName(countriesOnTmdb[i].Name))
					{
						countriesOnTmdb[i].RowState = RowState.Added;
						var countryToSave = base.Save(countriesOnTmdb[i]);
						countriesUpdated.Add(countryToSave);
					}
				}
				catch (Exception ex)
				{
					throw new Exception($"Error: {ex}");
				}
			}

			return countriesUpdated;
		}
	}
}