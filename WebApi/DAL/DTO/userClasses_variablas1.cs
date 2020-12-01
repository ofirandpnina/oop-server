using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;


namespace DAL.dto
{
    public class userClasses_variablas1
    {
        public int user_class_id { get; set; }
        public int variable_id { get; set; }

        public userClasses_variablas1()
        {

        }
        public userClasses_variablas1(userClasses_variables t)
        {
            user_class_id = t.user_class_id;
            variable_id = t.variable_id;
        }
        public static userClasses_variables FromDtoToEntity(userClasses_variablas1 ucv1)
        {
            userClasses_variables ucv = new userClasses_variables();
            ucv.variable_id = ucv1.variable_id;
            ucv.user_class_id = ucv1.user_class_id;
            return ucv;
        }


    }
}