using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using Prueba1.Models;
using Prueba1.Data;

namespace Prueba1.Controllers
{
    public class SupervisorController : ApiController
    {
        // GET api/Controller 
        [ActionName("lSup")]
        public List<Supervisor> Get()
        {
            return SupervisorData.ObtenerSupervisor();
        }

        // GET api/Controller/5
        [ActionName("SupId")]
        public Supervisor Get(int id)
        {
            return SupervisorData.ObtenerIdSupervisor(id);
        }

        // POST api/values
        [ActionName("RSup")]
        public bool Post([FromBody] Supervisor oSupervisor)
        {
            return SupervisorData.RegistrarSupervisor(oSupervisor);
        }
        [ActionName("Del")]
        // PUT api/values/5
        public bool Put([FromBody] Supervisor oSupervisor)
        {
            return SupervisorData.ActualizarSupervisor(oSupervisor);
        }

        // DELETE api/values/5
        [HttpDelete]
        [ActionName("ESup")]
        
        public bool EliminarSupervisor(int id)
            
        {
            return SupervisorData.EliminarSupervisor(id);
        }
        [HttpPut]
        [ActionName("ELSup")]
        public bool EliminarLogicaSupervisar(int id)

        {
            return SupervisorData.EliminarLogicaSupervisor(id);
        }
        [HttpPut]
        [ActionName("ALSup")]
        public bool ActivarLogicaSupervisar(int id)

        {
            return SupervisorData.ActivarLogicaSupervisor(id);
        }
    }
}
