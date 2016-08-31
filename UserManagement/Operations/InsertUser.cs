using System;
using UserManagement.Entities;
using UserManagement.Validator;

namespace UserManagement.Operations
{
    public class InsertUser
    {
        public static int Insert(User user)
        {
            if(!ValidateUser.CheckFields(user))
            {
                throw new Exception("Invalid inputs");
            }

            UserTableLinqToSQLDataContext db = new UserTableLinqToSQLDataContext();
            long? id = 0;
            db.spInsertUserTable(user.firstName,user.lastName,user.emailId,user.phoneNumber,ref id);

            return (int)id;
        }
    }
}
