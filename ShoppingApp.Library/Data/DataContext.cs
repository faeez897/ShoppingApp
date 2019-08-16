using Microsoft.EntityFrameworkCore;
using ShoppingApp.Library.POCO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoppingApp.Library.Data
{
    public class DataContext:DbContext
    {
        public DataContext() { }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
            optionsBuilder.UseSqlServer(@"Server=FAIZ\FAIZ;Database=ShoppingApp.Db;user id=sa;password=Dell2050;Trusted_Connection=True;MultipleActiveResultSets=True;");
        }
        
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }

        public virtual DbSet<User> Users { get; set; }
    }
}
