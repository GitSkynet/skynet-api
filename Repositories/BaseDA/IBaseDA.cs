using Entities.Base;
using Repositories.CoreDA;

namespace Repositories.BaseDA
{
	public interface IBaseDA
	{

	}

	public interface IBaseDA<T> : IBaseDA where T : class
	{
		IQueryable<T> AsQueryable();

		List<T> GetAll();

		T GetById(long id);
		T Save(T entity);
		List<T> Save(List<T> entity);
	}
}
