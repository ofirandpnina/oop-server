using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using BLL;
using DAL;
using DAL.dto;

namespace WebApi.Controllers
{
    public class classes_Controller : ApiController
    {

        // GET: api/classes_
        public List<Classs1> Get()  {   return ClassesManager.GetList();  }


        // GET: api/classes_/5
        public List<Classs1> GetClassById(int id)
        {
            Console.WriteLine("fdsfsfdsfd");
            return valuesShapeManager.GetClassById(id);
        }
       

        // POST: api/classes_
        public void Post([FromBody]string value)
        {
        }

        // PUT: api/classes_/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/classes_/5
        public void Delete(int id)
        {
        }
    }
}
