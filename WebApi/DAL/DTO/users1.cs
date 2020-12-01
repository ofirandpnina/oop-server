using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;


namespace DAL.dto
{
    public class users1
    {
        public int id { get; set; }
        public string email { get; set; }
        public string user_name { get; set; }
        public string password { get; set; }
        public int level { get; set; }
        public users1(users y)
        {
            id = y.id;
            email = y.email;
            user_name = y.email;
            password = y.password;
           //!!!!!!!!!!!!!!!!!!!!!
            level = 0;
        }
        public users1()
        {
                
        }


        public static users FromDtoToEntity(users1 u1)
        {
            users u = new users();
            u.id = u1.id;
            u.password = u1.password;
            u.email = u1.email;
            u.user_name = u1.user_name;
            u.level = u1.level;
            return u;
        }
    }
}