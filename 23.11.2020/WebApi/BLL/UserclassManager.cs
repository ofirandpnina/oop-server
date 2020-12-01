using DAL;
using DAL.dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace BLL
{
   public class UserclassManager
    {
        
        public static List<userClasss1> GetList()
        {
            oopEntities db = new oopEntities();

            List<userClasss1> lst = new List<userClasss1>();
            foreach (var item in db.userClasss.ToList())
            {
                lst.Add(new userClasss1(item));
            }
            return lst;
        }
        public static List<userClasss1> ClassesByUserId(int id)
        {
            oopEntities db = new oopEntities();
            List<userClasss1> lst2 = new List<userClasss1>();
            
            foreach (var item in db.userClasss.Where(l=>l.user_id==id))
            {
                lst2.Add(new userClasss1(item));
            }
            return lst2;
        }
        public static void AddUserClass(userClasss1 uc1)
        {
            oopEntities db = new oopEntities();
            userClasss uc=userClasss1.FromDtoToEntity(uc1);
            db.userClasss.Add(uc);
            db.SaveChanges();
        }
       
    }
}
