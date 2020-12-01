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
        static oopEntities db = new oopEntities();
        
        public static List<userClasss1> GetList()
        {
            

            List<userClasss1> lst = new List<userClasss1>();
            foreach (var item in db.userClasss.ToList())
            {
                lst.Add(new userClasss1(item));
            }
            return lst;
        }
        public static List<userClasss1> ClassesByUserId(int id)
        {
            
            List<userClasss1> lst2 = new List<userClasss1>();
            
            foreach (var item in db.userClasss.Where(l=>l.user_id==id))
            {
                lst2.Add(new userClasss1(item));
            }
            return lst2;
        }
        public static void AddUserClass(userClasss1 uc1)
        {
  
            userClasss uc=userClasss1.FromDtoToEntity(uc1);
            db.userClasss.Add(uc);
            db.SaveChanges();
        }
        //פונקיה שמחזירה פרטים בטבלה לפי האיידי של המשתמש
        public static userClasss GetDetailsUsrclss(int id)
        {
            var us = db.userClasss.First(x => x.user_id == id);
            return us;
        }
        //מחזיירה את כל העצמים של משתמש מסוים 
        public static List<userClasss1> GetObjectByuserId(int id)
        {
            
            List<userClasss> ucList = new List<userClasss>();
            ucList = db.userClasss.Where(x => x.user_id == id).ToList();
            List<userClasss1> ucList1 = new List<userClasss1>();
            foreach (var item in ucList)
            {
                ucList1.Add(new userClasss1(item));
            }
            return ucList1;
        }
        //קיבוץ כל האובייקטים לפי יוסר מסוים
        public static List<userClasss1>GetObjectByUserId(int id)
        {
            List<userClasss> ucList = new List<userClasss>();
            List<userClasss1> ucList1 = new List<userClasss1>();
            ucList = db.userClasss.Where(x => x.user_id == id).ToList();
            foreach (var item in ucList)
            {
                ucList1.Add(new userClasss1(item));
            }
            return ucList1;
        }

    }
}
