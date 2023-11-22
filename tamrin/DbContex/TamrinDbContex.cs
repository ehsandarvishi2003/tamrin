using Microsoft.EntityFrameworkCore;
using Microsoft.Identity.Client;
using tamrin.Entity;

namespace tamrin.DbContex
{
    public class TamrinDbContex:Microsoft.EntityFrameworkCore.DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Data Source=EHSAN;Initial Catalog=CarInfo;Integrated Security=True;MultipleActiveResultSets=true;TrustServerCertificate=True");

        }

        public DbSet<CarInfo> CarInfos { get; set; }
        public DbSet<User> Users { get; set; }

    }
}
