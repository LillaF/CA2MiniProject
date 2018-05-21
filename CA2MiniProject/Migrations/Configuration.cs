namespace CA2MiniProject.Migrations
{
    using CA2MiniProject.Models;
    using System;
    using System.Collections.Generic;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<CA2MiniProject.DAL.EnergyUsedContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(CA2MiniProject.DAL.EnergyUsedContext context)
        {
            var users = new List<User>
            {
            new User{FirstName="Carson",LastName="Alexander",Address="Tallaght", ApplianceID = 1, MinsUsed = 85},
            new User{FirstName="Carson",LastName="Alexander",Address="Tallaght", ApplianceID = 2, MinsUsed = 97},
            new User{FirstName="Carson",LastName="Alexander",Address="Tallaght", ApplianceID = 3, MinsUsed = 38},
            new User{FirstName="Carson",LastName="Alexander",Address="Tallaght", ApplianceID = 5, MinsUsed = 99},
            new User{FirstName="Meredith",LastName="Alonso",Address="Templeogue", ApplianceID = 1, MinsUsed = 124},
            new User{FirstName="Meredith",LastName="Alonso",Address="Templeogue", ApplianceID = 4, MinsUsed = 95},
            new User{FirstName="Meredith",LastName="Alonso",Address="Templeogue", ApplianceID = 5, MinsUsed = 85},
            new User{FirstName="Arturo",LastName="Anand",Address="Rathfarnham", ApplianceID = 1, MinsUsed = 23},
            new User{FirstName="Arturo",LastName="Anand",Address="Rathfarnham", ApplianceID = 2, MinsUsed = 57},
            new User{FirstName="Arturo",LastName="Anand",Address="Rathfarnham", ApplianceID = 3, MinsUsed = 105},
            new User{FirstName="Arturo",LastName="Anand",Address="Rathfarnham", ApplianceID = 4, MinsUsed = 77},
            new User{FirstName="Arturo",LastName="Anand",Address="Rathfarnham", ApplianceID = 5, MinsUsed = 22},
            new User{FirstName="Gytis",LastName="Barzdukas",Address="Tallaght", ApplianceID = 3, MinsUsed = 44},
            new User{FirstName="Gytis",LastName="Barzdukas",Address="Tallaght", ApplianceID = 4, MinsUsed = 55},
            new User{FirstName="Gytis",LastName="Barzdukas",Address="Tallaght", ApplianceID = 5, MinsUsed = 857},
            new User{FirstName="Yan",LastName="Li",Address="Blanchardstown", ApplianceID = 1, MinsUsed = 785},
            new User{FirstName="Yan",LastName="Li",Address="Blanchardstown", ApplianceID = 2, MinsUsed = 285},
            new User{FirstName="Yan",LastName="Li",Address="Blanchardstown", ApplianceID = 3, MinsUsed = 285},
            new User{FirstName="Yan",LastName="Li",Address="Blanchardstown", ApplianceID = 4, MinsUsed = 835},
            new User{FirstName="Yan",LastName="Li",Address="Blanchardstown", ApplianceID = 5, MinsUsed = 385},
            new User{FirstName="Peggy",LastName="Justice",Address="Templeogue", ApplianceID = 5, MinsUsed = 855},
            new User{FirstName="Laura",LastName="Norman",Address="Rathfarnham", ApplianceID = 3, MinsUsed = 385},
            new User{FirstName="Nino",LastName="Olivetto",Address="Blanchardstown", ApplianceID = 2, MinsUsed = 585}
            };
            users.ForEach(s => context.Users.Add(s));
            context.SaveChanges();

            var appliances = new List<Appliance>
            {
                new Appliance { ApplianceID = 1, EnergySrc = "Natural Gas",Brand = "Philips", Type = "Oven",Power= 1200, CostPerMin= 2 },
                new Appliance { ApplianceID = 2, EnergySrc = "Electric", Brand = "Morphy Richards", Type = "Kettle", Power = 500, CostPerMin = 6 },
                new Appliance { ApplianceID = 3, EnergySrc = "Electric", Brand = "Triton T90SR", Type = "Shower", Power = 9, CostPerMin = 8 },
                new Appliance { ApplianceID = 4, EnergySrc = "Natural Gas", Brand = "Philips", Type = "Hob", Power = 300, CostPerMin = 3 },
                new Appliance { ApplianceID = 5, EnergySrc = "Bottled Gas", Brand = "SuperSer", Type = "Fire", Power = 1200, CostPerMin = 8 }
            };
            appliances.ForEach(s => context.Appliances.Add(s));
            context.SaveChanges();
        }
    }
}
