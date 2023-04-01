using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonelApp.DAL.Repositories.Abstract
{
	public interface IRepository<Tentity> where Tentity :class
	{
		Tentity GetById(int id);
		IEnumerable<Tentity> GetAll();
		void Add(Tentity entity);
		void AddRange(IEnumerable<Tentity> entities);
		void Remove(int id);
		void RemoveRange(IEnumerable<Tentity> entities);

	}
}
