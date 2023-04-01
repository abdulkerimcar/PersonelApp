using PersonelApp.DAL.Repositories.Abstract;
using System.Collections.Generic;
using System.Linq;

namespace PersonelApp.DAL.Repositories.Concrete
{
	public class DepartmentRepository : Repository<Department>, IDepartmentRepository
	{
		
        public DepartmentRepository(PersonelContext context):base(context)
        {
            
        }
		public IEnumerable<Department> GetDepartmentsWithPersonels()
		{
			return PersonelContext.Departments.Include("Personels").ToList();
		}

		public IEnumerable<Department> GetTopDepartments(int count)
		{
				return PersonelContext.Departments.Take(count);
		}
        public PersonelContext PersonelContext { get { return _context as PersonelContext; } }
    }
	
}
