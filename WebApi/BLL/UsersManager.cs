using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using DAL.dto;
namespace BLL
{
    public class UsersManager
    {
        static oopEntities db = new oopEntities();
        public static List<users1> GetList()
        {
            //oopEntities db = new oopEntities();

            List<users1> lst = new List<users1>();
            foreach (var item in db.users.ToList())
            {
                lst.Add(new users1(item));
            }
            return lst;
        }
        public static users1 GetUserById(int id)
        {
            //oopEntities db = new oopEntities();
            users u = db.users.First(user => user.id == id);
            users1 u1 = new users1(u);
            return u1;
        }
        public static void AddUser(users1 u1)
        {
            //oopEntities db AddUserClass new oopEntities();
            //המרה מתצוגה לטבלה
            users u = users1.FromDtoToEntity(u1);
            //הוספה ושמירת שינויים
            db.users.Add(u);
            db.SaveChanges();
        }

        public static users1 Login(string email, string password)
        {
            users user = null;
            try {
                user = db.users.First(u => u.email == email);

                if (user.password != password) //אם הסיסמא שגויה
                    return null;
            }
            catch (Exception e) { //אם המשתמש לא קיים
                return null;
            }
           
            
            return new  users1( user); //המשתמש קיים והסיסמא לא שגויה
        }
        
    }
}
