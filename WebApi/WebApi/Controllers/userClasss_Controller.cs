using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using DAL;
using DAL.dto;
using BLL;
namespace WebApi.Controllers
{
    public class userClasss_Controller : ApiController
    {
        // GET: api/userClasss_
        public List<userClasss1> Get() { return UserclassManager.GetList(); }

        // GET: api/userClasss_/5
        public string Get(int id)
        {
            return "value";
        }
        [HttpPost]
        [Route("api/userClasss_/addUsers")]
        public void addUsers([FromBody]int a)
        {

        }

        //[HttpPost]
        //[Route("api/userClasss_/addUsers")]
        //public void addUsers1([FromBody]int a)
        //{

        //}

        // POST: api/userClasss_
        [HttpPost]
        public void AddUserClass([FromBody]userClasss1 uc1)
        {
            UserclassManager.AddUserClass(uc1);
        }


        // PUT: api/userClasss_/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/userClasss_/5
        public void Delete(int id)
        {
        }
    }
}
