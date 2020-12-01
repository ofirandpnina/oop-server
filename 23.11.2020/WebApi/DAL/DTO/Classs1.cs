
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DAL.dto
{
    public class Classs1
    {
        private object item;

        public Classs1(userClasss1 item)
        {

        }
        public Classs1(classes c)
        {
            id_class = c.id_class;
            class_name = c.class_name;
             image= c.image;
            description = c.description;


        }

        public Classs1(object item)
        {
            this.item = item;
        }

        public int id_class { get; set; }
        public string class_name { get; set; }
        public string image { get; set; }
        public string description { get; set; }
    }
}