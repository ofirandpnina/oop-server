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
        public static List<valuesShape1> GetList()
        {
            oopEntities db = new oopEntities();

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

        public static List<valuesShape1> GetValueShapesByVariableId(int id)
        {
            oopEntities db = new oopEntities();
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


    }
}
