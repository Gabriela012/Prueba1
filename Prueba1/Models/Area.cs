using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Prueba1.Models
{
    public class Area
    {
        public int id_Area { get; set; }
        public int cantidad_Trabajador { get; set; }
        public string nombre_Area { get; set; }
        public int id_Supervisor_Area { get; set; }
        public int estadoArea { get; set; }
    }
}