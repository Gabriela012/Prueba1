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
    public class AreaController : ApiController
    {
        // GET api/Controller 
        [ActionName("lAre")]
        public List<Area> Get()
        {
            return AreaData.ObtenerArea();
        }


        // GET api/Controller/5
        [ActionName("OIdAre")]
        public Area Get(int id)
        {
            return AreaData.ObtenerIdArea(id);
        }

        // POST api/values
        [ActionName("RAre")]
        public bool Post([FromBody] Area oArea)
        {
            return AreaData.RegistrarArea(oArea);
        }

        // PUT api/values/5
        [ActionName("AAre")]
        public bool Put([FromBody] Area oArea)
        {
            return AreaData.ActualizarArea(oArea);
        }

        // DELETE api/values/5
        [HttpDelete]
        [ActionName("EAre")]
        public bool EliminarArea(int id)

        {
            return AreaData.EliminarArea(id);
        }
        [HttpPut]
        [ActionName("ELAre")]
        public bool EliminarLogicaArea(int id)

        {
            return AreaData.EliminarLogicaArea(id);
        }
        [HttpPut]
        [ActionName("ALAre")]
        public bool ActivarLogicaSupervisar(int id)

        {
            return AreaData.ActivarLogicaArea(id);
        }
    }
}
