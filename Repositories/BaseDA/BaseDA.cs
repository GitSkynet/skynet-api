using Entities.Base;
using Microsoft.EntityFrameworkCore;

namespace Repositories.BaseDA
{
	public class BaseDA<T> : IBaseDA<T> where T : EntityBase
	{
		private readonly DbContext dbContext;

		public DbContext DbContext => dbContext;

		public BaseDA(DbContext dbContext) => this.dbContext = dbContext;

		protected IQueryable<TEntity> AsQueryableIf<TEntity>(bool condition) where TEntity : class
		{
			return condition
			? AsQueryable<TEntity>()
			: AsQueryable<TEntity>().Where(x => false);
		}

		public IQueryable<TEntity> AsQueryable<TEntity>() where TEntity : class => DbContext.Set<TEntity>().AsQueryable();

		public IQueryable<T> AsQueryable()
		{
			return DbContext.Set<T>().AsQueryable();
		}

		public List<T> GetAll()
		{
			return AsQueryable<T>().ToList();
		}

		public virtual T GetById(long id)
		{
			return (from x in AsQueryable()
				where x.Id == id
				select x).FirstOrDefault()!;
		}

		public virtual T Save(T entity)
		{
			dbContext.Entry(entity).State = (EntityState)entity.RowState;
			dbContext.SaveChanges();
			DbContext.Entry(entity).State = EntityState.Detached;
			return entity;
		}

		public virtual List<T> Save(List<T> entities)
		{
			foreach (var entity in entities)
			{
				dbContext.Entry(entity).State = (EntityState)entity.RowState;
				dbContext.SaveChanges();
			}
			return entities;
		}
	}
}
