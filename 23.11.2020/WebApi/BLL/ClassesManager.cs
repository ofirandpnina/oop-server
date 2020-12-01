using DAL;
using DAL.dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace BLL
{
   public class ClassesManager
    {//מחזירה רשימה של המחלקות
        public static List<Classs1> GetList()
        {
            oopEntities db = new oopEntities();

            List<Classs1> lst = new List<Classs1>();
            foreach (var item in db.classes.ToList())
            {
                lst.Add(new Classs1(item));
            }
            return lst;
        }
        //מחזירה  שם של מחלקה לפי ה-ID שלה
        public static List<Classs1> GetClassById(int id)
        {
            List<Classs1> u = new List<Classs1>();
           
            foreach (var item in ClassesByUserId(id))
            {
                u.Add(new Classs1(item));
            }
            return u;
        }

        private static IEnumerable<object> ClassesByUserId(int id)
        {
            throw new NotImplementedException();
        }
        //  פונקציה המוסיפה מחלקה לטבלה
        public static void AddCls(Classs1 c)
        {
            oopEntities db = new oopEntities();
            //classes dtc = Classs1.FromDtoToEntity(c);
            //db.users.Add(dtc);
            db.SaveChanges();
        }
        //ונקציה  המדפיסה את השם של המחלקה
        public static void PrintClsName(Classs1 c)
        {
            Console.WriteLine("Public Class "+ c.class_name);
        }   
    }
}
