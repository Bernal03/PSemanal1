namespace PracticaSemanal_EventosCiudades.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<PracticaSemanal_EventosCiudades.Models.EyCDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
            ContextKey = "PracticaSemanal_EventosCiudades.Models.EyCDbContext";
        }

        protected override void Seed(PracticaSemanal_EventosCiudades.Models.EyCDbContext context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method
            //  to avoid creating duplicate seed data.
        }
    }
}
