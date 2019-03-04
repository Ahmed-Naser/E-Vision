using Evision.API.Models;
using Microsoft.EntityFrameworkCore;

namespace Evision.API.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options) {}
        public DbSet<Product> Products { get; set; }
    }
}