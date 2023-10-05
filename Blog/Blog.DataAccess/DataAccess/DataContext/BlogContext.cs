using Blog.Entities.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blog.DataAccess.DataAccess.DataContext
{
    public class BlogContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseNpgsql("server=localhost;user Id=postgres;password=7s5OqKHs;database=blog");
        }
        public DbSet<User> User { get; set; }
        public DbSet<Article> Article { get; set; }

        public DbSet<Comment> Comment { get; set; } 

        public DbSet<Category> Category { get; set; }

        public DbSet<Subcategory> Subcategory { get; set; }


        // add-migration b
        // update-database -verbose -force
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            #region Data

            var admin = new User
            {
                ID = Guid.NewGuid().ToString(),
                Name = "admin",
                Active = true,
                Rol = Entities.Enums.Rol.Admin,
                Password = "123456"
            };

            modelBuilder.Entity<User>().HasData(admin);

            #endregion
        }
    }
}
