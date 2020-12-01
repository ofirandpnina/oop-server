using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DAL.dto
{
    public class classes_variables1
    {
        public int class_id { get; set; }
        public int variable_id { get; set; }

        public classes_variables1()
        {

        }
        public classes_variables1(classes_variables c)
        {
            class_id = c.class_id;
            variable_id = c.variable_id;
        }
    }
}