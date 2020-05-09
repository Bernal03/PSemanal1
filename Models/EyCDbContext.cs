using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Security.Claims;
using System.Web;
using System.Web.ClientServices;

namespace PracticaSemanal_EventosCiudades.Models
{
    public class EyCDbContext:DbContext
    {
        public EyCDbContext():base("MyConnection")
        {

        }

        public DbSet<Ciudad> Ciudades { get; set; }
        public DbSet<Evento> Eventos { get; set; }
    }
}