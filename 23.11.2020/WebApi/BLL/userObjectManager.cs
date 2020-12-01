using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL.dto;
using DAL;
namespace BLL
{
   public class userObjectManager
    {
        public static List<userObject1> GetList()
        {
            oopEntities db = new oopEntities();

            List<userObject1> lst = new List<userObject1>();
            foreach (var item in db.userObject.ToList())
            {
                lst.Add(new userObject1(item));
            }
            return lst;
        }
    }
}
