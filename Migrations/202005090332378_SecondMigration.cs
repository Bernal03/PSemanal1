namespace PracticaSemanal_EventosCiudades.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class SecondMigration : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Ciudads", "NombreCiudad", c => c.String());
            DropColumn("dbo.Ciudads", "Ciudades");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Ciudads", "Ciudades", c => c.String());
            DropColumn("dbo.Ciudads", "NombreCiudad");
        }
    }
}
