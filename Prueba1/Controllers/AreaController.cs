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
        public List<Area> Get()
        {
            return AreaData.ObtenerArea();
        }

        // GET api/Controller/5
        public Area Get(int id)
        {
            return AreaData.ObtenerIdArea(id);
        }

        // POST api/values
        public bool Post([FromBody] Area oArea)
        {
            return AreaData.RegistrarArea(oArea);
        }

        // PUT api/values/5
        public bool Put([FromBody] Area oArea)
        {
            return AreaData.ActualizarArea(oArea);
        }

        // DELETE api/values/5
        public bool EliminarArea(int id)

        {
            return AreaData.EliminarArea(id);
        }
    }
}
