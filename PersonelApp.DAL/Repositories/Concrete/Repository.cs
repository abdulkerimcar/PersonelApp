using PersonelApp.DAL.Repositories.Abstract;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.Infrastructure.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonelApp.DAL.Repositories.Concrete
{
	public class Repository<Tentity> : IRepository<Tentity> where Tentity : class
	{
		protected DbContext _context;
		private DbSet<Tentity> _dbset;
        public Repository(DbContext context)
        {
			_context = context;
			_dbset = _context.Set<Tentity>();
        }
        public void Add(Tentity entity)
		{
			_dbset.Add(entity);
		}

		public void AddRange(IEnumerable<Tentity> entities)
		{
			_dbset.AddRange(entities);
		}

		public IEnumerable<Tentity> GetAll()
		{
			return _dbset.ToList();
		}

		public Tentity GetById(int id)
		{
			return _dbset.Find(id);
		}

		public void Remove(int id)
		{
			_dbset.Remove(GetById(id));
		}

		public void RemoveRange(IEnumerable<Tentity> entities)
		{
			_dbset.RemoveRange(entities);
		}
	}
}
