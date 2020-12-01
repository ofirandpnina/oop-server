using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DAL.dto
{
    public class userObject1
    {
        public int id { get; set; }
        public Nullable<int> user_id { get; set; }
        public string object_name { get; set; }
        public Nullable<int> user_class_id { get; set; }
        public userObject1(userObject t)
        {
            id = t.id;
            user_id = t.user_id;
            object_name = t.object_name;
            user_class_id = t.user_class_id;
        }
        public userObject1()
        {
                
        }
    }
}