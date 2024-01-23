using CleanArchitecture.Application.Contracts.GoogleBooksContracts;
using CleanArchitecture.Application.Contracts.OpenBooksContracts;
using CleanArchitecture.Application.Services.GoogleBooks;
using CleanArchitecture.Application.Services.OpenBooks;
using DataAccess.RESTServices.GoogleBooks.Interfaces;
using DataAccess.RESTServices.GoogleBooks.Services;
using DataAccess.RESTServices.TheMovieDB.Interfaces;
using DataAccess.RESTServices.TheMovieDB.Services;
using DataContext.DbContexts.OpenBooksDbContext;
using DataContext.DbContexts.TmdbDbContext;
using DomainService.Contracts;
using DomainService.Contracts.OpenBooks;
using DomainService.Contracts.TMDB;
using DomainService.Services.GoogleBooks;
using DomainService.Services.OpenBooks;
using DomainService.Services.TMDB;
using Dto.Mappings.GoogleBooks;
using Dto.Mappings.OpenBooks;
using Microsoft.EntityFrameworkCore;
using Repositories.GoogleBooksRepo;
using Repositories.OpenBooksRepo;
using Repositories.TMDBRepo;
using Repository.Contracts.GoogleBooks;
using Repository.Contracts.OpenBooks;
using Repository.Contracts.TMDB;
using System.Reflection;

namespace WebApi
{
    public static class ConfigServiceCollectionExtensions
    {
        public static IServiceCollection AddConfig(this IServiceCollection services, IConfiguration config)
        {
            services.AddSingleton<IConfiguration>(provider => config);
            services.AddTransient<IBooksContract, BooksService>();
            services.AddTransient<IAuthorsContract, AuthorService>();
            services.AddTransient<ICategoriesContract, CategoriesService>();
            services.AddTransient<ISubCategoriesContract, SubCategoriesService>();
			services.AddTransient<IGoogleBooksContract, GoogleBooksService>();
            services.AddTransient<IConsumingGoogleBooksQueryService, ConsumingGoogleQueryService>();
            services.AddTransient<IQueryServiceTMDB, TmdbQueryService>();
            services.AddTransient <IGoogleBooksApplicationService, GoogleBooksApplicationService>();
            services.AddTransient <IBooksApplicationService, BooksApplicationService>();
            services.AddTransient <IAuthorsApplicationService, AuthorsApplicationService> ();
            services.AddTransient <ICategoriesApplicationService, CategoriesApplicationService>();
            services.AddTransient <ISubCategoriesApplicationService, SubCategoriesApplicationService>();
			// TMDB Configuration
			services.AddScoped<ITVShowBL, TVShowBL>();
			services.AddScoped<IMovieBL, MovieBL>();
			services.AddScoped<IGenreBL, GenreBL>();
			services.AddScoped<ISpokenLanguageBL, SpokenLanguageBL>();
			services.AddScoped<IProductionCompaniesBL, ProductionCompaniesBL>();
			services.AddScoped<IProductionCountriesBL, ProductionCountriesBL>();
			services.AddScoped<IMoviesGenresBL, MoviesGenresBL>();
			services.AddScoped<IMoviesProductionCountriesBL, MoviesProductionCountriesBL>();
			services.AddScoped<IMoviesProductionCompaniesBL, MovieProductionCompaniesBL>();
			services.AddScoped<IMovieSpokenLanguagesBL, MovieSpokenLanguagesBL>();
			services.AddScoped<ITVShowDA, TVShowDA>();
			services.AddScoped<IMovieDA, MovieDA>();
			services.AddScoped<IGenreDA, GenreDA>();
			services.AddScoped<ISpokenLanguageDA, SpokenLanguageDA>();
			services.AddScoped<IProductionCompaniesDA, ProductionCompaniesDA>();
			services.AddScoped<IProductionCountriesDA, ProductionCountriesDA>();
			services.AddScoped<IMoviesGenresDA, MoviesGenresDA>();
			services.AddScoped<IMoviesProductionCountriesDA, MoviesProductionCountriesDA>();
			services.AddScoped<IMoviesProductionCompaniesDA, MoviesProductionCompaniesDA>();
			services.AddScoped<IMovieSpokenLanguagesDA, MovieSpokenLanguageDA>();
			services.AddScoped<TVShowBL>();
			services.AddScoped<MovieBL>();
			services.AddScoped<GenreBL>();
			services.AddScoped<SpokenLanguageBL>();
			services.AddScoped<MoviesGenresBL>();
			services.AddScoped<MoviesProductionCountriesBL>();
			services.AddScoped<MovieProductionCompaniesBL>();
			services.AddScoped<MovieSpokenLanguagesBL>();
			services.AddScoped<ProductionCompaniesDA>();
			services.AddScoped<ProductionCountriesDA>();
			services.AddScoped<SpokenLanguageDA>();
			services.AddScoped<MoviesGenresDA>();
			services.AddScoped<MoviesProductionCountriesDA>();
			services.AddScoped<MoviesProductionCompaniesDA>();
			services.AddScoped<MovieSpokenLanguageDA>();
			services.AddDbContext<TmdbDbContext>(options => options.UseSqlServer(config.GetConnectionString("TMDBConnection")), ServiceLifetime.Scoped);
			// End TMDB Configuration

			services.AddDbContext<OpenBooksDbContext>(options => options.UseSqlServer(config.GetConnectionString("DefaultConnection")));
			services.AddTransient<BooksService>();
            services.AddTransient<AuthorService>();
            services.AddTransient<CategoriesService>();
            services.AddTransient<SubCategoriesService>();
            services.AddSingleton<GoogleBooksService>();
			services.AddSingleton<ConsumingGoogleQueryService>();
            services.AddSingleton<TmdbQueryService>();
            services.AddSingleton<GoogleBooksApplicationService>();
            services.AddTransient<BooksApplicationService>();
            services.AddTransient<AuthorsApplicationService> ();
            services.AddTransient<CategoriesApplicationService>();
            services.AddTransient<SubCategoriesApplicationService>();
            services.AddTransient<OpenBooksDbContext>();
            services.AddTransient<IBooksAssociationRepo, BooksAssociationRepo>();
            services.AddTransient<IAuthorsAssociationRepo, AuthorsAssociationRepo> ();
            services.AddTransient<ICategoriesAssociationRepo, CategoriesAssociationRepo>();
            services.AddTransient<ISubCategoriesAssociationRepo, SubCategoriesAssociationRepo>();
            services.AddTransient<IGoogleBooksAssociationRepo, GoogleBooksAssociationRepo>();
            services.AddAutoMapper(typeof(BooksMigrationMapping).GetTypeInfo().Assembly);
            services.AddAutoMapper(typeof(CategoriesMigrationMapping).GetTypeInfo().Assembly);
            services.AddAutoMapper(typeof(VolumeGoogleBooksMapping).GetTypeInfo().Assembly);
            services.AddAutoMapper(typeof(GoogleBooksDTOtoViewModel).GetTypeInfo().Assembly);
            services.AddAutoMapper(typeof(VolumelistToDTOMapping).GetTypeInfo().Assembly);
            services.AddAutoMapper(typeof(VolumeDTOtoViewModel).GetTypeInfo().Assembly);
            services.AddAutoMapper(typeof(SubCategoriesDBtoSubCategoriesDTO).GetTypeInfo().Assembly);

            return services;
        }
    }
}
