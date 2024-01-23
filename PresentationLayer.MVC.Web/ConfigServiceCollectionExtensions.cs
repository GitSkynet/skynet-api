using CleanArchitecture.Application.Contracts.GoogleBooksContracts;
using CleanArchitecture.Application.Contracts.OpenBooksContracts;
using CleanArchitecture.Application.Services.GoogleBooks;
using CleanArchitecture.Application.Services.OpenBooks;
using DataAccess.RESTServices.GoogleBooks.Interfaces;
using DataAccess.RESTServices.GoogleBooks.Services;
using DataAccess.RESTServices.TheMovieDB.Interfaces;
using DataAccess.RESTServices.TheMovieDB.Services;
using DataContext.DbContexts.OpenBooksDbContext;
using DomainService.Contracts;
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
            services.AddTransient<IGoogleBooksContract, GoogleBooksService>();
            services.AddTransient<ITVShowBL, TVShowBL>();
            services.AddTransient<IConsumingGoogleBooksQueryService, ConsumingGoogleQueryService>();
            services.AddTransient<IQueryServiceTMDB, TmdbQueryService>();
            services.AddTransient <IGoogleBooksApplicationService, GoogleBooksApplicationService>();
            services.AddTransient <IBooksApplicationService, BooksApplicationService>();
            services.AddDbContext<DbContext>(options => options.UseSqlServer(config.GetConnectionString("DefaultConnection")));
            services.AddTransient<BooksService>();
            services.AddSingleton<GoogleBooksService>();
            services.AddSingleton<TVShowBL>();
            services.AddSingleton<ConsumingGoogleQueryService>();
            services.AddSingleton<TmdbQueryService>();
            services.AddSingleton<GoogleBooksApplicationService>();
            services.AddTransient<BooksApplicationService>();
            services.AddTransient<OpenBooksDbContext>();
            services.AddTransient<IBooksAssociationRepo, BooksAssociationRepo>();
            services.AddTransient<IGoogleBooksAssociationRepo, GoogleBooksAssociationRepo>();
            services.AddTransient<ITVShowDA, TVShowDA>();
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
