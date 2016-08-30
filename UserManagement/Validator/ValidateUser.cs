using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UserManagement.Validator
{
    public class ValidateUser
    {
        public static bool isUserExits(int id)
        {
            UserTableLinqToSQLDataContext db = new UserTableLinqToSQLDataContext();

            var query = from user in db.UserTables where user.Id == id select user;
            if (query.Count() == 0)
                return false;
            return true;
        }
    }
}
