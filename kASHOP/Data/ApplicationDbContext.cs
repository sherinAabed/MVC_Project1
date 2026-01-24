using Microsoft.EntityFrameworkCore;

namespace kASHOP.Data
{
    public class ApplicationDbContext : DbContext

    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
            //DB for dev
            //optionsBuilder.UseSqlServer("Server=.;Database=KShopDb;TrustServerCertificate=True;Trusted_Connection=True");
            //DB for production
            optionsBuilder.UseSqlServer("Server = db38953.public.databaseasp.net; Database=db38953; User Id = db38953; Password=7t%YH#5i+8sR; Encrypt=True; TrustServerCertificate=True; MultipleActiveResultSets=True;");
        }
    }
}
