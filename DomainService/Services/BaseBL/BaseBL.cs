using DomainService.Contracts.BaseContracts;
using Repositories.BaseDA;

namespace DomainService.Services.BaseBL
{
	public abstract class BaseBL<T> : IBaseBL where T : class
	{
		protected IBaseDA<T> DataAccess { get; set; }
		protected BaseBL(IBaseDA<T> baseDA)
		{
			DataAccess = baseDA;
		}

		public virtual List<T> GetAll() => DataAccess.GetAll();
		
		public virtual T GetById(long id) => DataAccess.GetById(id);

		public virtual T Save(T entity) => DataAccess.Save(entity);

		public virtual List<T> Save(List<T> entities) => DataAccess.Save(entities);
	}
}
