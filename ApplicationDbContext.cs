using India_Mart_Api.Model;
using Microsoft.EntityFrameworkCore;

namespace India_Mart_Api
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) { }

        public DbSet<CrmRecord> CrmRecords { get; set; }
    }
}
