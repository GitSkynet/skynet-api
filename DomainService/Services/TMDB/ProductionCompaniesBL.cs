using AutoMapper;
using DataAccess.RESTServices.TheMovieDB.Interfaces;
using DomainService.Contracts.TMDB;
using DomainService.Services.BaseBL;
using Entities.Base;
using Entities.TMDB.Movies;
using Repository.Contracts.TMDB;

namespace DomainService.Services.TMDB
{
	public class ProductionCompaniesBL : BaseBL<ProductionCompany>, IProductionCompaniesBL
	{
		private readonly IQueryServiceTMDB queryService;
		private readonly IMoviesProductionCompaniesBL movieCompaniesBL;

		private IProductionCompaniesDA prodCompDA => (IProductionCompaniesDA)DataAccess;
		private readonly IMapper mapper;
		public ProductionCompaniesBL(IProductionCompaniesDA iProdCompDA, IQueryServiceTMDB iQqueryService, 
			IMapper mapper, IMoviesProductionCompaniesBL iMovieCompaniesBL)
			: base((Repositories.BaseDA.IBaseDA<ProductionCompany>)iProdCompDA)
		{
			this.mapper = mapper;
			queryService = iQqueryService;
			movieCompaniesBL = iMovieCompaniesBL;
		}

		public ProductionCompany GetByIdTMDB(long id) => prodCompDA.GetByIdTMDB(id);
		public ProductionCompany GetByName(string name) => prodCompDA.GetByName(name);

		public bool AlreadyExistsByIdTMDB(long id) => prodCompDA.AlreadyExistsByIdTMDB(id);
		public bool AlreadyExistsByName(string name) => prodCompDA.AlreadyExistsByName(name);

		public ProductionCompany Update(ProductionCompany productionCompany)
		{
			if (!prodCompDA.AlreadyExistsById(productionCompany.Id))
				throw new Exception("No existe la Compañía de Producción especificada en la base de datos");

			ProductionCompany prodCompOnDb = base.GetById(productionCompany.Id);
			prodCompOnDb.IdTMDB = productionCompany.IdTMDB;
			prodCompOnDb.LogoPath = !string.IsNullOrEmpty(productionCompany.LogoPath) ? productionCompany.LogoPath : "";
			prodCompOnDb.Name = productionCompany.Name;
			prodCompOnDb.OriginCountry = productionCompany.OriginCountry;
			prodCompOnDb.RowState = RowState.Modified;
			return base.Save(prodCompOnDb);
		}

		public ProductionCompany Create(ProductionCompany productionCompany)
		{
			if (!prodCompDA.AlreadyExistsByIdTMDB(productionCompany.IdTMDB))
				productionCompany.RowState = RowState.Added;
			else
				throw new Exception("Ya existe una Compañía de Producción con ese nombre");
			return base.Save(productionCompany);
		}

		public ProductionCompany Delete(long Id)
		{
			bool hasMovies = prodCompDA.HasMoviesAssociated(Id);
			if (hasMovies)
				throw new Exception("La Compañía de Producción tiene películas asociadas y no se puede eliminar");
			else
			{
				var productionToDelete = base.GetById(Id);
				productionToDelete.RowState = RowState.Deleted;
				return base.Save(productionToDelete);
			}
		}

		public void SaveAssociatedCompanies(long movieId, List<ProductionCompany> companies)
		{
			if (companies == null)
				companies = new();

			List<MovieProductionCompany> moviesCompanies = new();

			if (companies != null)
			{
				for (int i = 0; i <= companies.Count() - 1; i++)
				{
					ProductionCompany company = companies[i];
					if (AlreadyExistsByName(company.Name))
					{
						ProductionCompany companyOnDb = GetByName(company.Name);
						companies[i].Id = companyOnDb.Id;
					}
					else
					{
						var companyToCreate = new ProductionCompany()
						{
							IdTMDB = company.Id,
							LogoPath = company.LogoPath != null ? company.LogoPath : "",
							Name = company.Name,
							OriginCountry = company.OriginCountry
						};
						var companyAdded = Create(companyToCreate);
						companies[i].Id = companyAdded.Id;
					}
				}
			}

			foreach (ProductionCompany company in companies)
			{
				MovieProductionCompany prodComp = new()
				{
					MovieID = movieId,
					ProductionCompanyID = company.Id,
					ProductionCompanies= new()
				};
				moviesCompanies.Add(prodComp);
			}
			movieCompaniesBL.Save(movieId, moviesCompanies);
		}
	}
}
