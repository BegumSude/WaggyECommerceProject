using Microsoft.EntityFrameworkCore;
using WaggyProject.Entities;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;

namespace WaggyProject.Context
{
    public class WaggyContext : IdentityDbContext<AppUser,AppRole,int>
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=WIN-9OO5RQ9OAPT\\SQLEXPRESS;Database=WaggyDb;Integrated Security=True;TrustServerCertificate=True");
        }


        //pluralize
        public DbSet<Banner> Banners { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<Testimonial> Testimonials { get; set; }
        public DbSet<Message> Messages { get; set; }

    }
}
