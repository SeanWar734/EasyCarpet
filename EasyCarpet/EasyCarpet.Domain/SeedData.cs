using EasyCarpet.Domain.Models;
using System;

namespace EasyCarpet.Domain
{
    public static class SeedData
    {
        //Todo: Add Seed data here.
        private static Guid TrafficMasterBrownId = Guid.Parse("9cf37a50-a08f-4ed6-9505-2cb18af43605");
        public static Carpet TrafficMasterBrown => new Carpet()
        {
            Id = TrafficMasterBrownId,
            Width = 12m,
            Length = 200m,
            SquareYardPrice = 5.89m,
            Brand = "Traffic Master",
            Description = "Medium Beige / Dark Beige flecks, indoor residential",
            Name = "TrafficMaster: Brown",
            Image = "TrafficMasterBrown.jpg",
            Style = "Plush",
            CreatedDate = DateTime.Now,
            ModifiedDate = DateTime.Now
        };

        private static Guid HomeDepotId = Guid.Parse("943ba50f-41c5-4881-9a97-7e4de399836d");
        public static Retailer HomeDepot => new Retailer()
        {
            Id = HomeDepotId,
            Address = "321 Schoolcraft Rd",
            State = "Michigan",
            City = "Livonia",
            CompanyName = "Home Depot",
            Description = "A large box chain retailer with good prices",
            PhoneNumber = "734-111-2222",
            CreatedDate = DateTime.Now,
            ModifiedDate = DateTime.Now
        };

        private static Guid SeanId = Guid.Parse("ebb89a92-dd6a-43ef-9301-3a58c479120a");
        public static Installer SeanWarchuck => new Installer()
        {
            Id = SeanId,
            FirstName = "Sean",
            LastName = "Warchuck",
            RetailerId = HomeDepotId,
            Area = 0m,
            SquareYardPrice = 4.99m,
            PhoneNumber = "734-788-6458",
            CreatedDate = DateTime.Now,
            ModifiedDate = DateTime.Now
        };

        private static Guid KyleId = Guid.Parse("14999486-bc73-4651-be18-fa308608831d");
        public static Customer KyleWarchuck => new Customer()
        {
            Id = KyleId,
            FirstName = "Kyle",
            LastName = "Warchuck",
            Address = "123 Grennada St",
            City = "Livonia",
            State = "Michigan",
            PhoneNumber = "734-111-6548",
            CreatedDate = DateTime.Now,
            ModifiedDate = DateTime.Now
        };

        private static Guid FirstOrderId = Guid.Parse("6ea4eafb-0b96-40e3-ab04-da5db6195a17");
        public static Order FirstOrder => new Order()
        {
            Id = FirstOrderId,
            CarpetId = TrafficMasterBrownId,
            InstallerId = SeanId,
            CustomerId = KyleId,
            RetailerId = HomeDepotId,
            Total = 100m,
            CreatedDate = DateTime.Now,
            ModifiedDate = DateTime.Now
        };
    }
}
