using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DomainService.Contracts.BaseContracts
{
	public interface IBaseBL
	{

	}

	public interface IBaseBL<T> : IBaseBL where T : class
	{
		List<T> GetAll();

		T GetById(long id);
		T Save(T entity);
		List<T> Save(List<T> entities);
	}
}
