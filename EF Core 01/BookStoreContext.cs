using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF_Core_01
{
    internal class BookStoreContext:DbContext
    {

        public BookStoreContext():base() 
        {
            
        }


        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=.;Database=EFCoreDemo;Trusted_Connection=true;TrustServerCertificate=True;");
        }

        public DbSet<Book> Books { get; set; }
        public DbSet<Auther> Authers { get; set; }
        public DbSet<Category> Categories { get; set; }
    }
}
