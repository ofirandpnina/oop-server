using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DAL.dto
{
    public class valuesShape1
    {
        public int value_id { get; set; }
        public Nullable<int> class_id { get; set; }
        public Nullable<int> variable_id { get; set; }
        public string value_name { get; set; }
        public string value_image { get; set; }

        public valuesShape1(valuesShape p)
        {
            value_id = p.value_id;
            class_id = p.class_id;
            variable_id = p.variable_id;
            value_name = p.value_name;
            value_image = p.value_image;
        }
        public valuesShape1()
        {

        }

    }
}