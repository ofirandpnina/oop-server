using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL.dto;
using DAL;
namespace BLL
{
    public class valuesShapeManager
    {
        public static oopEntities db = new oopEntities();
        public static List<valuesShape1> GetList()
        {

            List<valuesShape1> lst = new List<valuesShape1>();
            foreach (var item in db.valuesShape.ToList())
            {
                lst.Add(new valuesShape1(item));
            }
            return lst;
        }

        public static List<Classs1> GetClassById(int id)
        {
            throw new NotImplementedException();
        }
        // מחזירה את כל הערכים שיכולים להיות לווריאבל מסויים
        public static List<valuesShape1> GetValueShapesByVariableId(int id)
        {
            //סינון הטבלה לתוך רשימה מסוג הטבלה
            List<valuesShape> vsList = new List<valuesShape>();
            vsList = db.valuesShape.Where(vs => vs.variable_id == id).ToList();
            //העתקת הרשימה המסוננת לרשימה מסוג התצוגה
            List<valuesShape1> vsList1 = new List<valuesShape1>();
            foreach (var item in vsList)
            {
                vsList1.Add(new valuesShape1(item));
            }
            return vsList1;
        }
        //פונקציה המחזירה את הפרטים בשורה בטבלה לפי האיידי
        public static valuesShape GetDetailsValueShape(int id)
        {
            var vs = db.valuesShape.First(x => x.value_id == id);
            return vs;
        }
        //פונקציה המחזירה את כל הערכים של קוד המחלקה

        public static List<valuesShape1> GetValueShapesByClassId(int id)
        {
            
            List<valuesShape> vsList = new List<valuesShape>();
            vsList = db.valuesShape.Where(vs => vs.class_id == id).ToList();
            
            List<valuesShape1> vsList1 = new List<valuesShape1>();
            foreach (var item in vsList)
            {
                vsList1.Add(new valuesShape1(item));
            }
            return vsList1;
        }
    }
}
