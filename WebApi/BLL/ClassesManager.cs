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
       static oopEntities db = new oopEntities();
        public static List<Classs1> GetList()
        {
            

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
            List<Classs1> c1 = new List<Classs1>();
           
            foreach (var item in ClassesByUserId(id))
            {
                c1.Add(new Classs1(item));
            }
            return c1;
        }

        private static IEnumerable<object> ClassesByUserId(int id)
        {
            throw new NotImplementedException();
        }
        //  פונקציה המוסיפה מחלקה לטבלה
        public static void AddCls(Classs1 c)
        {
            oopEntities db = new oopEntities();
            classes dtc = Classs1.FromDtoToEntity(c);
            db.classes.Add(dtc);
            db.SaveChanges();
        }
        //ונקציה  המדפיסה את השם של המחלקה
        //למה שאר הפרופרטיז לא עובדים
        public static void PrintClsName(Classs1 c1)
        {
            Console.WriteLine("Public Class "+ c1.Class_name);
        }   
        // פונקציה שמקלת את האיידי של המחלקה ומחזירה את פרטייה
   
        public static classes GetDetailsClasses(int id)
        {
            var dt = db.classes.First(x => x.id_class == id);
            
            return dt;
        }    
    }

}
