using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using DAL.DTO;
namespace BLL
{
    class User_variableManager
    {
        static oopEntities db = new oopEntities();
        //פונקציה המחזירה פרטים על הטבלה לפי האיידי
        public static userVariable GetDetailUsrVariable(int id)
        {
            var uv = db.userVariable.First(x => x.user_class_id == id);
            return uv;
        }
        //קיבוץ לפי ווריאבל איידי
        public static List<userVariables1 > GetVariableIdByUsrClsId(int id)
        {
            
            List<userVariable> uvList = new List<userVariable>();
            uvList = db.userVariable.Where(x => x.user_class_id == id).ToList();
            List<userVariables1> uvList1 = new List<userVariables1>();
            foreach (var item in uvList)
            {
                uvList1.Add(new userVariables1(item));
            }
            return uvList1;
        }
    }
}
