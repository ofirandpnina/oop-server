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
        public static List<variables1> GetList()
        {
            oopEntities db = new oopEntities();

            List<variables1> lst = new List<variables1>();
            foreach (var item in db.variable.ToList())
            {
                lst.Add(new variables1(item));
            }
            return lst;
        }
    }
}
