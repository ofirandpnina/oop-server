using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using DAL;
using BLL;
using DAL.dto;
namespace WebApi.Controllers
{
    public class valuesShape_Controller : ApiController
    {
        // GET: api/valuesShape_
        public List<valuesShape1> GetList() { return valuesShapeManager.GetList(); }

        // GET: api/valuesShape_/5
        public List<valuesShape1> Get(int id)
        {
            return null;
        }

        public List<valuesShape1> GetValueShapesByVariableId(int id)
        {
            return valuesShapeManager.GetValueShapesByVariableId(id);
        }


        // POST: api/valuesShape_
        public void Post([FromBody]string value)
        {
        }

        // PUT: api/valuesShape_/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/valuesShape_/5
        public void Delete(int id)
        {
        }
    }
}
