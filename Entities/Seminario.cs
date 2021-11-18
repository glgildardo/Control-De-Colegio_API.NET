using System;
using System.Collections.Generic;

namespace ApiControlDeColegio.Entities
{
    public class Seminario
    {
        
        public string SeminarioId {get; set;}
        public string ModuloId {get; set;}
        public string NombreSeminario {get; set;}
        public DateTime FechaInicio {get; set;}
        public DateTime FechaFin {get; set;}
        public virtual Modulo Modulo {get; set;}
        public virtual List<DetalleActividad> DetalleActividades {get; set;}

    }
}