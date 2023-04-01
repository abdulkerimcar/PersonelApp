using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonelApp.DAL
{
    public class PersonelContext:DbContext
    {
        //Personelcontext hangi veritabanında yazacağını bilmediğinden dolayı ekliyoruz.
        public PersonelContext():base("PersonelContext")
        {
            
        }
        public DbSet<Department> Departments { get; set; }
        public DbSet<Personel> Personels { get; set; }
    }
}
