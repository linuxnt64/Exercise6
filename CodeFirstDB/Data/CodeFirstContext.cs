using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using CodeFirstDB.EntityModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeFirstDB.Data
{
    public class CodeFirstContext : DbContext
    {
        public DbSet<Address> Adresses { get; set; }
        public DbSet<Customer> Customers { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\C-Sharp-fundamentals\cs\Exercise6\CodeFirstDB\Data\CodeFirstDBFile.mdf;Integrated Security=True;Connect Timeout=30");
        }
    }
}
