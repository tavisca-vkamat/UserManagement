using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UserManagement.Entities;

namespace UserManagement.Operations
{
    public class SelectUser
    {
        public static List<User> SelectAll()
        {
            UserTableLinqToSQLDataContext db = new UserTableLinqToSQLDataContext();

            var query = from user in db.UserTables select new User() { Id = user.Id, firstName = user.FIrstName, lastName = user.LastName, emailId = user.EmailId, phoneNumber = user.PhoneNumber};

            if(query.Count() == 0)
            {
                return null;
            }
            return query.ToList();
        }

        public static UserTable SelectById(int id)
        {
            UserTableLinqToSQLDataContext db = new UserTableLinqToSQLDataContext();

            UserTable user = db.UserTables.FirstOrDefault(u => u.Id.Equals(id));

            if (user == null)
                return null;
                       
            return user;
        }
    }
}
