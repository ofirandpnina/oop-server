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
    public class userObject_Controller : ApiController
    {
        // GET: api/userObject_
        public List<userObject1> Get() { return userObjectManager.GetList(); }

        // GET: api/userObject_/5
        public string Get(int id)
        {
            return "value";
        }

        // POST: api/userObject_
        public void Post([FromBody]string value)
        {
        }

        // PUT: api/userObject_/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/userObject_/5
        public void Delete(int id)
        {
        }
    }
}
