using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DAL.dto
{
    public class userClasss1
    {

        public int user_class_id { get; set; }
        public Nullable<int> class_id { get; set; }
        public Nullable<int> user_id { get; set; }

        public userClasss1(userClasss e)
        {
            user_class_id = e.user_class_id;
            class_id = e.class_id;
            user_id = e.user_id;
        }
        public userClasss1()
        {
                
        }
        public static userClasss FromDtoToEntity(userClasss1 uc1)
        {
            userClasss uc = new userClasss();
            uc.user_class_id = uc1.user_class_id;
            uc.class_id = uc1.class_id;
            uc.user_id = uc1.user_id;
            return uc;

        }
    }
}