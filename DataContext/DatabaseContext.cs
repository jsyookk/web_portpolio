using Microsoft.EntityFrameworkCore;
using MyFirstProj_TreeView.Models;
using System;

namespace MyFirstProj_TreeView.DataContext
{
    public class DatabaseContext : DbContext
    {

        public DbSet<User> Users { get; set; }
        public DbSet<Category> Categorys { get; set; }
        public DbSet<File> Files { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
           
            //throw new UnauthorizedAccessException();

        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=localhost;Database=MyFirstProj;User Id=sa;
            Password = 1q2w3e;");

        }

    }

}
