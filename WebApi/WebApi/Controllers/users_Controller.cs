﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using DAL;
using BLL;
using DAL.dto;
using Newtonsoft.Json.Linq;

namespace WebApi.Controllers
{
    public class users_Controller : ApiController
    {
        // GET: api/users_
        public List<users1> Get() { return UsersManager.GetList(); }

        // GET: api/users_/5
        public users1 Get(int id)
        {
            return UsersManager.GetUserById(id);
        }

      
        //// POST: api/users_
        //public void Post([FromBody]string value)
        //{
        //}
        [HttpPost]
        public void AddUser([FromBody]users1 u1)
        {
            UsersManager.AddUser(u1);
        }

        //login
        [HttpPost]
        public users1  Login([FromBody]JObject loginDetails)
        {
            string email = loginDetails["email"].ToObject<string>();
            string password = loginDetails["password"].ToObject<string>();
            return UsersManager.Login(email,password);
        }

        // PUT: api/users_/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/users_/5
        public void Delete(int id)
        {
        }
    }
}
