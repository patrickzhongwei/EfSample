using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace EfSample.DataModels
{
    public class Context: DbContext
    {
        public DbSet<Class> Class { get; set; }

        public DbSet<Student> Students { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            //PW: note: .\\SQLEXPRESS will ends up "Instance failure" at PM>update-database,
            //    so always use .\SQLEXPRESS, very funny!!
            optionsBuilder.UseSqlServer(@"Server=.\SQLEXPRESS;Database=EfSample;Trusted_Connection=True;");
        }
    }
}
