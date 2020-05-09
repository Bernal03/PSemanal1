namespace PracticaSemanal_EventosCiudades.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Ciudads",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Ciudades = c.String(),
                        Pais = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Eventoes",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        NombreDeEvento = c.String(),
                        FechaInicio = c.DateTime(nullable: false),
                        FechaFin = c.DateTime(nullable: false),
                        CiudadId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Ciudads", t => t.CiudadId, cascadeDelete: true)
                .Index(t => t.CiudadId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Eventoes", "CiudadId", "dbo.Ciudads");
            DropIndex("dbo.Eventoes", new[] { "CiudadId" });
            DropTable("dbo.Eventoes");
            DropTable("dbo.Ciudads");
        }
    }
}
