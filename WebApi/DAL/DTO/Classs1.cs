
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DAL.dto
{
    public  class Classs1
    {
        private object item;
        private int id_class { get; set; }
        private string class_name;//{ get; set; }
        private string image { get; set; }
        private string description { get; set; }
       

        public string Class_name    {
            get { return class_name; }
            set { class_name = value; }
        }

        //מזה הפונקציה הזו
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
        public static classes FromDtoToEntity(Classs1 c1)
        {
            classes c = new classes();
            c.id_class = c1.id_class;
            c.class_name = c1.class_name;
            c.image = c1.image;
            c.description = c1.description;
            return c;
        }
       

    }
}