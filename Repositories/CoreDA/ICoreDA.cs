using Entities.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repositories.CoreDA
{
	public interface ICoreDA
	{

	}
	public interface ICoreDA<T> : ICoreDA where T : IEntity, new()
	{
		void Insert(T entity);
		void Update(T entity);
		void Delete(T entity);
		T GetById(long id);
		List<T> GetAll();
	}
}
