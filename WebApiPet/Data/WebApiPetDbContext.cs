using Microsoft.EntityFrameworkCore;
using WebApiPet.Models;

namespace WebApiPet.Data
{
    public class WebApiPetDbContext : DbContext
    {
        public WebApiPetDbContext(DbContextOptions<WebApiPetDbContext> options)
            : base(options)
        {
        }

        public DbSet<Product> Products { get; set; }
    }
}