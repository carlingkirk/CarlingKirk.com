namespace CarlingKirk.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<CarlingKirk.Models.ApplicationDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
            ContextKey = "CarlingKirk.Models.ApplicationDbContext";
        }

        protected override void Seed(CarlingKirk.Models.ApplicationDbContext context)
        {
        }
    }
}
