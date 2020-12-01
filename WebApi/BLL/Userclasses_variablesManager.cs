using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL.dto;
using DAL;

namespace BLL
{
    class Userclasses_variablesManager
    {
        static oopEntities db = new oopEntities();
        // מחזירה פטים מהשורה בטבלה לפי האיידי
        public static userClasses_variables GetDetailsUsrClsVrbl(int id)
        {
            var ucv = db.userClasses_variables.First(x => x.user_class_id == id);
            return ucv;
        }
        //מחזירה ליסט  לפי יוסר קלאס
        public static List<userClasses_variablas1> GetVariableIdByUsrClsId(int id)
        {
            List<userClasses_variables> ucList = new List<userClasses_variables>();
            ucList = db.userClasses_variables.Where(x => x.user_class_id == id).ToList();
            List<userClasses_variablas1> ucList1 = new List<userClasses_variablas1>();
            foreach (var item in ucList)
            {
                ucList1.Add(new userClasses_variablas1(item));
            }
            return ucList1;
        }
    }
}
