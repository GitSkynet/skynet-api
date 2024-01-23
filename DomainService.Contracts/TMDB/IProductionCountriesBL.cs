using Entities.TMDB.Movies;

namespace DomainService.Contracts.TMDB
{
	public interface IProductionCountriesBL
	{
		public List<ProductionCountry> GetAll();

		public ProductionCountry GetById(long Id);

		public ProductionCountry GetByIso(string name);

		public ProductionCountry Update(ProductionCountry productionCountry);

		public ProductionCountry Create(ProductionCountry productionCountry);

		public ProductionCountry Delete(long Id);

		public Task<List<ProductionCountry>> UpdateCountriesFromTmdb();

		public bool AlreadyExistsByIso(string iso31661);

		/// <summary>
		/// <item>Guarda las compañías de producción asociadas a la película.</item>
		/// Comprueba por Iso31661 si existe en BBDD o no y cambia el Id de cada objeto
		/// recibido de la lista. Crea el objeto <see cref="MovieProductionCountry"/> para
		/// expresar la relación en base de datos y guarda los cambios en las relaciones
		/// </summary>
		/// <param name="movieId">Identificador de la película a buscar</param>
		/// <param name="prodCounts">Lista de<see cref="ProductionCountry"/> para crear las realciones
		/// requeridas entre la película y el País de Producción</param>
		void SaveAssociatedProdCounts(long movieId, List<ProductionCountry> prodCounts);
	}
}
