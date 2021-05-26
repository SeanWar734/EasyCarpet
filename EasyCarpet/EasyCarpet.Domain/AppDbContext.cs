using EasyCarpet.Domain.Interfaces;
using EasyCarpet.Domain.Models;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace EasyCarpet.Domain
{
    public class AppDbContext : DbContext
    {
        private readonly IDateTime _dateTime;

        public AppDbContext()
        {
        }

        public AppDbContext(DbContextOptions options)
            : base(options)
        {
        }

        public AppDbContext(DbContextOptions options,
            IDateTime dateTime)
            : base(options)
        {
            _dateTime = dateTime;
        }

        //Todo: Add DbSet
        public DbSet<Carpet> Carpets { get; set; }
        public DbSet<Retailer> Retailers { get; set; }
        public DbSet<Installer> Installers { get; set; }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Order> Orders { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=.\;Integrated Security=True;Database=EasyCarpetDb");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            foreach (var entityType in modelBuilder.Model.GetEntityTypes())
            {
                // equivalent of modelBuilder.Conventions.Remove<OneToManyCascadeDeleteConvention>();
                // and modelBuilder.Conventions.Remove<ManyToManyCascadeDeleteConvention>();
                entityType.GetForeignKeys()
                    .Where(fk => !fk.IsOwnership && fk.DeleteBehavior == DeleteBehavior.Cascade)
                    .ToList()
                    .ForEach(fk => fk.DeleteBehavior = DeleteBehavior.Restrict);
            }

            //Todo: Add Seed Data
            modelBuilder.Entity<Carpet>().HasData(SeedData.TrafficMasterBrown);
            modelBuilder.Entity<Retailer>().HasData(SeedData.HomeDepot);
            modelBuilder.Entity<Installer>().HasData(SeedData.SeanWarchuck);
            modelBuilder.Entity<Customer>().HasData(SeedData.KyleWarchuck);
            modelBuilder.Entity<Order>().HasData(SeedData.FirstOrder);
        }

        public override Task<int> SaveChangesAsync(CancellationToken cancellationToken = new CancellationToken())
        {
            SetAuditInfo();

            return base.SaveChangesAsync(cancellationToken);
        }

        public override int SaveChanges()
        {
            SetAuditInfo();

            return base.SaveChanges();
        }

        private void SetAuditInfo()
        {
            foreach (var entry in ChangeTracker.Entries<BaseAudit>())
            {
                switch (entry.State)
                {
                    case EntityState.Added:
                        entry.Entity.CreatedDate = _dateTime.Now;
                        entry.Entity.ModifiedDate = entry.Entity.CreatedDate;
                        break;
                    case EntityState.Modified:
                        entry.Entity.ModifiedDate = _dateTime.Now;
                        break;
                }
            }
        }

    }
}
