using System.Linq;
using UserManagement.Entities;

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

        public static bool CheckFields(User user)
        {
            if (user.Id < 0 || user.firstName == null || user.lastName == null || user.phoneNumber == null)
            {
                return false;
            }
            return true;
        }
    }
}
