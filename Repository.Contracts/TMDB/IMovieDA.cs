using Entities.TMDB.Movies;
using Entities.TMDB.TVShows;
using Entities.TMDB;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository.Contracts.TMDB
{
	public interface IMovieDA
	{
		/// <summary>
		/// Comprueba si ya existe la película en base de datos
		/// </summary>
		/// <param name="movieId">Identificador de la película a buscar</param>
		/// <returns>booleano que indica si la <see cref="Movie"/> ya existe o no en BBDD</returns>
		bool AlreadyExists(long movieId);
		
		/// <summary>
		/// Comprueba si existe la película por IDTMDB
		/// </summary>
		/// <param name="Id">Identificador de la película a buscar</param>
		/// <returns>Booleano que indica si la <see cref="Movie"/> ya existe o no en BBDD</returns>
		bool AlreadyExistsByIdTmdb(long Id);

		/// <summary>
		/// Obtiene la película por el ID especificado
		/// </summary>
		/// <param name="movieID">Identificador de la película a buscar</param>
		/// <returns>Un objeto de tipo <see cref="Movie"/> con la película requerida</returns>
		Movie GetById(long movieID);

		/// <summary>
		/// Obtiene la película por el IDTMDB especificado
		/// </summary>
		/// <param name="id">Identificador de la película a buscar</param>
		/// <returns>Un objeto de tipo <see cref="Movie"/> con la película requerida</returns>
		Movie GetByIdTMDB(long id);

		/// <summary>
		/// Obtiene las películas más populares (actualizado desde TMDB)
		/// </summary>
		/// <param name="language">Lenguage a buscar, por defecto; Español</param>
		/// <param name="results">Límite de resultados a mostrar</param>
		/// <returns>Una <see cref="List{T}"/> de <see cref="Movie"/> con el filtro aplicado</returns>
		List<Movie> GetMostPopular(string language, int results);

		/// <summary>
		/// Obtiene las últimas películas añadidas recientemente
		/// </summary>
		/// <param name="language">Lenguage a buscar, por defecto; Español</param>
		/// <param name="status">El estado por el que filtrar (Released, In Production, etc)</param>
		/// <param name="limit">Límite a aplicar para los resultados</param>
		/// <returns>Una <see cref="List{T}"/> de <see cref="Movie"/> con el filtro aplicado</returns>
		List<Movie> GetMostRecent(string language, string status, int limit);

		/// <summary>
		/// Obtiene las películas filtradas por Género
		/// </summary>
		/// <param name="genre">Género por el que buscar</param>
		/// <param name="language">Lenguage a buscar, por defecto; Español</param>
		/// <param name="results">Límite a aplicar para los resultados</param>
		/// <param name="adult">Booleano que especifica el filtro a aplicar</param>
		/// <returns>Una <see cref="List{T}"/> de <see cref="Movie"/> con el filtro aplicado</returns>
		List<Movie> GetByGenre(string genre, string language, int results, bool adult);

		/// <summary>
		/// Obtiene todas las películas marcadas como Upcoming
		/// </summary>
		/// <returns>Una <see cref="List{T}"/> de <see cref="Movie"/> con las películas marcadas como Upcoming</returns>
		List<Movie> GetUpcoming();

		/// <summary>
		/// Obtiene todas las películas marcadas como Now Playing
		/// </summary>
		/// <returns>Una <see cref="List{T}"/> de <see cref="Movie"/> con las películas marcadas como Now Playing</returns>
		List<Movie> GetNowPlaying();

		/// <summary>
		/// Obtiene todas las películas marcadas como Trending Day
		/// </summary>
		/// <returns>Una <see cref="List{T}"/> de <see cref="Movie"/> con las películas marcadas como Trending Day</returns>
		List<Movie> GetTrendingDay();

		/// <summary>
		/// Obtiene todas las películas marcadas como Trending Week
		/// </summary>
		/// <returns>Una <see cref="List{T}"/> de <see cref="Movie"/> con las películas marcadas como Trending Week</returns>
		List<Movie> GetTrendingWeek();

		/// <summary>
		/// Obtiene todas las películas marcadas como Top Rated
		/// </summary>
		/// <returns>Una <see cref="List{T}"/> de <see cref="Movie"/> con las películas marcadas como Top Rated</returns>
		List<Movie> GetTopRated();
	}
}
