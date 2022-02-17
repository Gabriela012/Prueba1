using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Prueba1.Models
{
    public class Supervisor
    {
        public int id_Supervisor { get; set; }
        public string nombre { get; set; }
        public string apellido { get; set; }

        public int dni { get; set; }
        public string sexo { get; set; }
        public string direccion { get; set; }
        public int telefono { get; set; }

        public int estadoSupervisor { get; set; }


    }
}