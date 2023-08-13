using Microsoft.EntityFrameworkCore;
using PlatformServices.Models;

namespace PlatformServices.Data
{
    public class AppDBContext : DbContext
    {
        public AppDBContext(DbContextOptions<AppDBContext> opt) : base(opt)
        {

        }
        
        public DbSet<Platform> Platforms { get; set; }
    }
}