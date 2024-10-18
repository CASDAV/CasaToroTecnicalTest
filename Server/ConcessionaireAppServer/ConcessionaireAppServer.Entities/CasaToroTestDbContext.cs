using ConcessionaireAppServer.Entities.Entities;
using Microsoft.EntityFrameworkCore;

namespace ConcessionaireAppServer.Entities
{
    public class CasaToroTestDbContext : DbContext
    {
        public DbSet<Sale> Sales { get; set; }
        public DbSet<Seller> Sellers { get; set; }
        public DbSet<Brand> Brands { get; set; }
        public DbSet<Vehicle> Vehicles { get; set; }
        public DbSet<TransmisionType> TransmisionTypes { get; set; }
        public DbSet<VehicleStatus> VehicleStatus { get; set; }
        public DbSet<VehicleType> VehicleTypes { get; set; }
        public DbSet<ViewSaleDetail> viewSalesDetails { get; set; }

        public CasaToroTestDbContext(DbContextOptions options) : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Sale>().ToTable("Sales");
            modelBuilder.Entity<Seller>().ToTable("Sellers");
            modelBuilder.Entity<Brand>().ToTable("Brands");
            modelBuilder.Entity<Vehicle>().ToTable("Vehicles");
            modelBuilder.Entity<VehicleStatus>().ToTable("VehicleStatus");
            modelBuilder.Entity<VehicleType>().ToTable("VehicleTypes");
            modelBuilder.Entity<TransmisionType>().ToTable("TransmisionType");

            modelBuilder.Entity<Prueba>().ToTable("Prueba");

            modelBuilder.Entity<Vehicle>()
                .Property(e => e.Price)
                .HasColumnType("decimal(18,4)");
            modelBuilder.Entity<Sale>()
                .Property(e => e.SaleAmount)
                .HasColumnType("decimal(18,4)");

            modelBuilder.Entity<Seller>()
                .HasMany(e => e.Sales)
                .WithOne(e => e.Seller)
                .HasForeignKey(e => e.SellerId)
                .IsRequired();

            modelBuilder.Entity<Vehicle>()
                .HasOne(e => e.Sale)
                .WithOne(e => e.Vehicle)
                .HasForeignKey<Sale>(e => e.VehicleId)
                .IsRequired();

            modelBuilder.Entity<Brand>()
                .HasMany(e => e.Vehicles)
                .WithOne(e => e.Brand)
                .HasForeignKey(e => e.BrandId)
                .IsRequired();

            modelBuilder.Entity<TransmisionType>()
                .HasMany(e => e.Vehicles)
                .WithOne(e => e.TransmissionType)
                .HasForeignKey(e => e.TransmissionTypeId)
                .IsRequired();

            modelBuilder.Entity<VehicleType>()
                .HasMany(e => e.Vehicles)
                .WithOne(e => e.VehicleType)
                .HasForeignKey(e => e.VehicleTypeId)
                .IsRequired();

            modelBuilder.Entity<VehicleStatus>()
                .HasMany(e => e.Vehicles)
                .WithOne(e => e.VehicleStatus)
                .HasForeignKey(e => e.StatusId)
                .IsRequired();

            modelBuilder.Entity<ViewSaleDetail>()
                .HasNoKey()
                .ToView("ViewSalesDetails");

            modelBuilder.Entity<ViewSaleDetail>()
                .Property(e => e.SaleAmount)
                .HasColumnType("decimal(18,4)");

            modelBuilder.Entity<VehicleType>().HasData(new VehicleType() { Id = -1, Name = "SUV" });
            modelBuilder.Entity<VehicleType>().HasData(new VehicleType() { Id = -2, Name = "Pickup" });
            modelBuilder.Entity<VehicleType>().HasData(new VehicleType() { Id = -3, Name = "Sedan" });
            modelBuilder.Entity<VehicleType>().HasData(new VehicleType() { Id = -4, Name = "Coupe" });
            modelBuilder.Entity<VehicleType>().HasData(new VehicleType() { Id = -5, Name = "Hatchback" });

            modelBuilder.Entity<VehicleStatus>().HasData(new VehicleStatus() { Id = -1, Status = "Available" });
            modelBuilder.Entity<VehicleStatus>().HasData(new VehicleStatus() { Id = -2, Status = "Sold" });

            modelBuilder.Entity<TransmisionType>().HasData(new TransmisionType() { Id = -1, Name = "Manual" });
            modelBuilder.Entity<TransmisionType>().HasData(new TransmisionType() { Id = -2, Name = "Automatic" });

            modelBuilder.Entity<Brand>().HasData(new Brand() { Id = -1, Name = "Mazda" });
            modelBuilder.Entity<Brand>().HasData(new Brand() { Id = -2, Name = "Mercedes" });
            modelBuilder.Entity<Brand>().HasData(new Brand() { Id = -3, Name = "Volkswagen" });
            modelBuilder.Entity<Brand>().HasData(new Brand() { Id = -4, Name = "Audi" });
            modelBuilder.Entity<Brand>().HasData(new Brand() { Id = -5, Name = "Toyota" });
            modelBuilder.Entity<Brand>().HasData(new Brand() { Id = -6, Name = "Ford" });
            modelBuilder.Entity<Brand>().HasData(new Brand() { Id = -7, Name = "Renault" });

            modelBuilder.Entity<Vehicle>().HasData(new Vehicle() { Id = -1, Color = "Red", BrandId = -1, DateAdded = DateTime.Now, Mileage = 0, Price = 93000000, Model = "CX-30", TransmissionTypeId = -2, VehicleTypeId = -1, StatusId = -1, Year=2024});

            modelBuilder.Entity<Vehicle>().HasData(new Vehicle() { Id = -2, Color = "Blue", BrandId = -1, DateAdded = DateTime.Now, Mileage = 0, Price = 93000000, Model = "CX-30", TransmissionTypeId = -2, VehicleTypeId = -1, StatusId = -1, Year = 2024 });

            modelBuilder.Entity<Vehicle>().HasData(new Vehicle() { Id = -3, Color = "Black", BrandId = -1, DateAdded = DateTime.Now, Mileage = 0, Price = 93000000, Model = "CX-30", TransmissionTypeId = -2, VehicleTypeId = -1, StatusId = -2, Year = 2024 });

            modelBuilder.Entity<Vehicle>().HasData(new Vehicle() { Id = -4, Color = "Gray", BrandId = -3, DateAdded = DateTime.Now, Mileage = 0, Price = 94000000, Model = "Nivus", TransmissionTypeId = -2, VehicleTypeId = -1, StatusId = -1, Year = 2024 });

            modelBuilder.Entity<Vehicle>().HasData(new Vehicle() { Id = -5, Color = "Red", BrandId = -3, DateAdded = DateTime.Now, Mileage = 0, Price = 94000000, Model = "Nivus", TransmissionTypeId = -2, VehicleTypeId = -1, StatusId = -1, Year = 2024 });

            modelBuilder.Entity<Vehicle>().HasData(new Vehicle() { Id = -6, Color = "Gray", BrandId = -3, DateAdded = DateTime.Now, Mileage = 0, Price = 94000000, Model = "Nivus", TransmissionTypeId = -2, VehicleTypeId = -1, StatusId = -2, Year = 2024 });

            modelBuilder.Entity<Vehicle>().HasData(new Vehicle() { Id = -7, Color = "Red", BrandId = -1, DateAdded = DateTime.Now, Mileage = 0, Price = 93000000, Model = "CX-30", TransmissionTypeId = -2, VehicleTypeId = -1, StatusId = -1, Year = 2024 });

            modelBuilder.Entity<Vehicle>().HasData(new Vehicle() { Id = -8, Color = "Red", BrandId = -1, DateAdded = DateTime.Now, Mileage = 0, Price = 93000000, Model = "CX-30", TransmissionTypeId = -2, VehicleTypeId = -1, StatusId = -1, Year = 2024 });


            modelBuilder.Entity<Seller>().HasData(new Seller() { Id = 1, Name = "TestSeller", Email = "test.sample@example.com", JoinDate = DateTime.Now, Location = "Test street", PhoneNumber = "4273629" });
            modelBuilder.Entity<Seller>().HasData(new Seller() { Id = 2, Name = "TestSeller2", Email = "test.sample2@example.com", JoinDate = DateTime.Now, Location = "Test street", PhoneNumber = "7332626" });

            modelBuilder.Entity<Sale>().HasData(new Sale() { Id = -1, SaleAmount = 93000000, SaleDate = DateTime.Now, SellerId = 1, VehicleId = -3, CustomerName = "TestCustomer1", CustomerEmail = "test.sampleCustomer1@example.com", CustomerPhone = "72651726" });

            modelBuilder.Entity<Sale>().HasData(new Sale() { Id = -2, SaleAmount = 94000000, SaleDate = DateTime.Now, SellerId = 2, VehicleId = -6, CustomerName = "TestCustomer2", CustomerEmail = "test.sampleCustomer2@example.com", CustomerPhone = "72651726" });


        }
    }
}
