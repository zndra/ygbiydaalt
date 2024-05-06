using Microsoft.EntityFrameworkCore;

namespace ygbiydaalt.Models
{
    public class TeslaCtx : DbContext
    {
        public TeslaCtx(DbContextOptions<TeslaCtx> options) : base(options)
        {
        }

        public DbSet<Car> Cars { get; set; }
        public DbSet<CarModel> CarModels { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<UserType> UserTypes { get; set; }
        public DbSet<PaymentType> PaymentTypes { get; set; }
        public DbSet<Sale> Sales { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }
    }
}
