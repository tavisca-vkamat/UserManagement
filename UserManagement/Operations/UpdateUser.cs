using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UserManagement.Validator;

namespace UserManagement.Operations
{
    public class UpdateUser
    {
        public static bool UpdateFirstName(int id,string newName)
        {
            UserTableLinqToSQLDataContext db = new UserTableLinqToSQLDataContext();

            if(ValidateUser.isUserExits(id))
            {
                UserTable us = SelectUser.SelectById(id);

                us.FIrstName = newName;

                db.SubmitChanges();
                return true;
            }
            return false;
        }

        public static bool UpdatePhoneNumber(int id, string phoneNumber)
        {
            UserTableLinqToSQLDataContext db = new UserTableLinqToSQLDataContext();

            if (ValidateUser.isUserExits(id))
            {
                UserTable us = SelectUser.SelectById(id);

                us.PhoneNumber = phoneNumber;
                db.SubmitChanges();
                return true;
            }
            return false;
        }
    }
}
