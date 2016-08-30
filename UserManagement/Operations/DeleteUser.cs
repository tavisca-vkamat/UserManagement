using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UserManagement.Validator;

namespace UserManagement.Operations
{
    public class DeleteUser
    {
        public static bool DeleteById(int id)
        {
            UserTableLinqToSQLDataContext db = new UserTableLinqToSQLDataContext();
            if (ValidateUser.isUserExits(id))
            {
                db.UserTables.DeleteOnSubmit(SelectUser.SelectById(id));
                db.SubmitChanges();
                return true;
            }
            return false;
        }
    }
}
