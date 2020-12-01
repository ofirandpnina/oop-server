using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL.dto;
using DAL;
namespace BLL
{
    public class variablesManager
    {
       static oopEntities db = new oopEntities();

        public static List<variables1> GetList()
        {

            List<variables1> lst = new List<variables1>();
            foreach (var item in db.variable.ToList())
            {
                lst.Add(new variables1(item));
            }
            return lst;
        }
        // פןנקציה המחזירה פרטים של הטלה לפי האיידי
        public static variable GetDetailsVariables(int id)
        {
            var v = db.variable.First(x => x.variable_id == id);
            return v;

        }
    }
}
