using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DAL.dto
{
    public class variables1
    {
        public int variable_id { get; set; }
        public string name_v { get; set; }
        public string default_shape { get; set; }

        public variables1(variable p)
        {
            variable_id = p.variable_id;
            name_v=p.name_v;
            default_shape = p.default_shape;

        }
        public variables1()
        {

        }
        public static variable FromDtoToEntity (variables1 v1)
        {
            variable v = new variable();
            v.variable_id = v1.variable_id;
            v.name_v = v1.name_v;
            v.default_shape = v1.default_shape;
            return v;
        }

    }
}