using Entities.TMDB.Movies;
using Microsoft.EntityFrameworkCore;

namespace DataContext.DbContexts.TmdbDbContext
{
	public class TmdbDbContext : DbContext
	{
		public TmdbDbContext(DbContextOptions<TmdbDbContext> options) : base(options)
		{
			this.ChangeTracker.LazyLoadingEnabled = true;
		}

		public DbSet<Movie> Movies { get; set; }
		public DbSet<Genre> Genres { get; set; }
		public DbSet<ProductionCompany> ProductionCompanies { get; set; }
		public DbSet<ProductionCountry> ProductionCountries { get; set; }
		public DbSet<SpokenLanguage> SpokenLanguage { get; set; }

		public DbSet<MoviesGenres> MoviesGenres { get; set; }
		public DbSet<MovieProductionCompany> MoviesProductionCountries { get; set; }
		public DbSet<MovieProductionCountry> MoviesProductionCompanies { get; set; }
		public DbSet<MovieSpokenLanguage> MovieSpokenLanguage { get; set; }

		protected override void OnModelCreating(ModelBuilder builder)
		{
			builder.Entity<Movie>()
				.HasMany(m => m.Genres)
				.WithMany(g => g.Movies)
				.UsingEntity<MoviesGenres>(
					j => j.ToTable("MoviesGenres")
							.HasOne(mg => mg.Genres)
							.WithMany(g => g.MoviesGenres)
							.HasForeignKey(mg => mg.GenreID)
							.OnDelete(DeleteBehavior.Cascade),
					j => j.HasOne(mg => mg.Movies)
							.WithMany(m => m.MoviesGenres)
							.HasForeignKey(mpc => mpc.MovieID)
							.OnDelete(DeleteBehavior.Cascade));

			builder.Entity<Movie>()
				.HasMany(m => m.ProductionCountries)
				.WithMany(pc => pc.Movies)
				.UsingEntity<MovieProductionCountry>(
					j => j.ToTable("MoviesProductionCountries")
							.HasOne(mpc => mpc.ProductionCountries)
							.WithMany(pc => pc.MovieProductionCountries)
							.HasForeignKey(mpc => mpc.ProductionCountryID)
							.OnDelete(DeleteBehavior.Cascade),
					j => j.HasOne(mpc => mpc.Movies)
							.WithMany(m => m.MovieProductionCountries)
							.HasForeignKey(mpc => mpc.MovieID)
							.OnDelete(DeleteBehavior.Cascade));

			builder.Entity<Movie>()
				.HasMany(m => m.ProductionCompanies)
				.WithMany(pc => pc.Movies)
				.UsingEntity<MovieProductionCompany>(
					j => j.ToTable("MoviesProductionCompanies")
						  .HasOne(mpc => mpc.ProductionCompanies)
						  .WithMany(pc => pc.MovieProductionCompanies)
						  .HasForeignKey(mpc => mpc.ProductionCompanyID)
						  .OnDelete(DeleteBehavior.Cascade),
					j => j.HasOne(mpc => mpc.Movies)
						  .WithMany(m => m.MovieProductionCompanies)
						  .HasForeignKey(mpc => mpc.MovieID)
						  .OnDelete(DeleteBehavior.Cascade));

			builder.Entity<Movie>()
				.HasMany(m => m.SpokenLanguages)
				.WithMany(sl => sl.Movies)
				.UsingEntity<MovieSpokenLanguage>(
					j => j.ToTable("MoviesSpokenLanguages")
						  .HasOne(msl => msl.SpokenLanguages)
						  .WithMany(sl => sl.MovieSpokenLanguages)
						  .HasForeignKey(mpc => mpc.SpokenLanguageID)
						  .OnDelete(DeleteBehavior.Cascade),
					j => j.HasOne(msl => msl.Movies)
						  .WithMany(m => m.MovieSpokenLanguages)
						  .HasForeignKey(mpc => mpc.MovieID)
						  .OnDelete(DeleteBehavior.Cascade));

			foreach (var property in builder.Model.GetEntityTypes()
				.SelectMany(t => t.GetProperties())
				.Where(p => p.ClrType == typeof(decimal) || p.ClrType == typeof(decimal?)))
			{
				property.SetColumnType("decimal(18,2)");
			}

			base.OnModelCreating(builder);
			builder.ApplyConfigurationsFromAssembly(typeof(TmdbDbContext).Assembly);
		}
	}
}