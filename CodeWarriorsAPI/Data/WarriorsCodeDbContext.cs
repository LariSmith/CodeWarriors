using Microsoft.EntityFrameworkCore;

namespace CodeWarriorsAPI.Data
{
    public class WarriorsCodeDbContext : DbContext
    {
        public WarriorsCodeDbContext(DbContextOptions<WarriorsCodeDbContext> options) : base(options) { }

        
    }
}
