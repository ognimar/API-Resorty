using Microsoft.EntityFrameworkCore;
using API_Resorty.Entities;

namespace API_Resorty.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext>options) : base(options) { 
        }
        public DbSet<Resort> Resorts { get; set; }
    }
}
