using Entities.OpenBooks;
using Microsoft.EntityFrameworkCore;
using System.Data;

namespace DataContext.DbContexts.OpenBooksDbContext
{
	public class OpenBooksDbContext : DbContext
    {
        public OpenBooksDbContext(DbContextOptions<OpenBooksDbContext> options) : base(options)
        {
			this.ChangeTracker.LazyLoadingEnabled = true;
		}

		public DbSet<Book> Books { get; set; }
        public DbSet<Author> Authors { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<SubCategory> SubCategories { get; set; }

        public DbSet<AuthorsBooks> AuthorsBooks { get; set; }

		protected override void OnModelCreating(ModelBuilder builder)
        {
			builder.Entity<Book>()
				.HasOne(b => b.Categories)
				.WithMany()
				.HasForeignKey(b => b.CategoryId)
				.OnDelete(DeleteBehavior.NoAction);

			builder.Entity<Book>()
				.HasOne(b => b.SubCategories)
				.WithMany()
				.HasForeignKey(b => b.SubCategoryId)
				.OnDelete(DeleteBehavior.NoAction);

			builder.Entity<Category>()
				.HasMany(c => c.Subcategories)
				.WithOne()
				.HasForeignKey(s => s.CategoryId)
				.OnDelete(DeleteBehavior.NoAction);

			builder.Entity<AuthorsBooks>()
				.HasKey(ba => new { ba.BookId, ba.AuthorId });

			foreach (var property in builder.Model.GetEntityTypes()
				.SelectMany(t => t.GetProperties())
				.Where(p => p.ClrType == typeof(decimal) || p.ClrType == typeof(decimal?)))
				{
					property.SetColumnType("decimal(18,2)");
				}

			base.OnModelCreating(builder);
            builder.ApplyConfigurationsFromAssembly(typeof(OpenBooksDbContext).Assembly);
        }
    }
}
