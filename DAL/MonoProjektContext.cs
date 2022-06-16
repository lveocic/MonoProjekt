using Microsoft.EntityFrameworkCore;

namespace MonoProjekt.DAL
{
    public class MonoProjektContext : DbContext
    {
        #region Constructors

        public MonoProjektContext(DbContextOptions<MonoProjektContext> options)
        {
            Database.EnsureCreated();
        }

        #endregion Constructors

        #region Properties

        public DbSet<VehicleMakeEntity> VehicleMakers { get; set; }

        #endregion Properties

        #region Methods

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.UseSerialColumns();
        }

        #endregion Methods
    }
}