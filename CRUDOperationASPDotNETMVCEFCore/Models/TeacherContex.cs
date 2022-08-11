using Microsoft.EntityFrameworkCore;

namespace CRUDOperationASPDotNETMVCEFCore.Models
{
    public class TeacherContex : DbContext
    {
        protected readonly IConfiguration Configuration;

        public TeacherContex(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        protected override void OnConfiguring(DbContextOptionsBuilder options)
        {
            // connect to sql server with connection string from app settings
            options.UseSqlServer(Configuration.GetConnectionString("DefaultDatabase"));
        }
        public DbSet<Teacher> Teachers { get; set; }

    }
}
