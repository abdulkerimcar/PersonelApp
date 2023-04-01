using PersonelApp.DAL.Repositories.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonelApp.DAL
{
	public interface IUnitOfWork : IDisposable
	{
		//Idisposable eğer unitofwork ün işlemleri bittiğinde direk buradaki işlemleri sıfırlayacak.

		IDepartmentRepository DepartmentRepository { get; }
		IPersonelRepository PersonelRepository { get; }

		int Complete();
	}
}
