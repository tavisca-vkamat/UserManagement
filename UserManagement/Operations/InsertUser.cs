using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UserManagement.Entities;

namespace UserManagement.Operations
{
    public class InsertUser
    {
        public static int Insert(User user)
        {
            if(user.Id < 0 || user.firstName==null || user.lastName==null || user.phoneNumber==null)
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
