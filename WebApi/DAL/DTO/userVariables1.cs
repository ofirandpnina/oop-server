using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.DTO
{
     public class userVariables1
    {

        public int user_class_id { get; set; }
        public int variable_id { get; set; }

        public userVariables1(userVariable y)
        {
            user_class_id = y.user_class_id;
            variable_id = y.variable_id;
        }
        public userVariables1()
        {

        }


        public static userVariable FromDtoToEntity(userVariables1 u1)
        {
            userVariable u = new userVariable();
            u.user_class_id = u1.user_class_id;
            u.variable_id = u1.variable_id;
            return u;
        }

    }
}
