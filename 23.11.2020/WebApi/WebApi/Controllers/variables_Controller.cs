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
    public class variables_Controller : ApiController
    {
        // GET: api/variables_
        public List<variables1> Get() { return variablesManager.GetList(); }

        // GET: api/variables_/5
        public string Get(int id)
        {
            return "value";
        }

        // POST: api/variables_
        public void Post([FromBody]string value)
        {
        }

        // PUT: api/variables_/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/variables_/5
        public void Delete(int id)
        {
        }
    }
}
