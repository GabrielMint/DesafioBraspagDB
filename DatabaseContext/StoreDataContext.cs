using Microsoft.EntityFrameworkCore;

namespace DesafioDatabase{
    public class StoreDataContext : DbContext{

        public DbSet<Acquirer> Acquirers { get; set; }
        public DbSet<Tax> Taxes { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionBuilder){
            //VERIFICAR
            optionBuilder.UseInMemoryDatabase(@"server=.;database=DesafioDatabaseDb;trusted_connection=true");
        }

    }
}