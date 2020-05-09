using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace PracticaSemanal_EventosCiudades.Models
{
    public class Evento
    {
        public int Id { get; set; }
        public string NombreDeEvento { get; set; }
        public DateTime FechaInicio { get; set; }
        public DateTime FechaFin { get; set; }
        public int CiudadId { get; set; }
        [ForeignKey("CiudadId")]
        public Ciudad Ciudad { get; set; }
    }
}