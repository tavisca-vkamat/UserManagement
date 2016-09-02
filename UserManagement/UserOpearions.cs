using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UserManagement.Entities;
using UserManagement.Operations;
using UserManagement.Validator;

namespace UserManagement
{
    public class UserOpearions : IUser
    {
        public string emailId
        {
            get
            {
                return emailId;
            }

            set
            {
                emailId = value;
            }
        }

        public string firstName
        {
            get
            {
                return firstName;
            }

            set
            {
                firstName = value;
            }
        }

        public int Id
        {
            get
            {
                return Id;
            }

            set
            {
                Id = value;
            }
        }

        public string lastName
        {
            get
            {
                return lastName;
            }

            set
            {
                lastName = value;
            }
        }

        public string phoneNumber
        {
            get
            {
                return phoneNumber;
            }

            set
            {
                phoneNumber = value;
            }
        }

        public bool DeleteById(int id)
        {
            UserTableLinqToSQLDataContext db = new UserTableLinqToSQLDataContext();
            if (ValidateUser.isUserExits(id))
            {
                UserTable user = db.UserTables.FirstOrDefault(u => u.Id.Equals(id));
                db.UserTables.DeleteOnSubmit(user);
                db.SubmitChanges();
                return true;
            }
            return false;
        }

        public UserTable SelectById(int id)
        {
            UserTableLinqToSQLDataContext db = new UserTableLinqToSQLDataContext();

            UserTable user = db.UserTables.FirstOrDefault(u => u.Id.Equals(id));

            if (user == null)
                return null;

            return user;
        }

        public bool UpdateFirstName(int id, string newName)
        {
            UserTableLinqToSQLDataContext db = new UserTableLinqToSQLDataContext();

            if (ValidateUser.isUserExits(id))
            {
                UserTable user = db.UserTables.FirstOrDefault(u => u.Id.Equals(id));

                if (user != null)
                {
                    user.FIrstName = newName;

                    db.SubmitChanges();
                    return true;
                }
            }
            return false;
        }
    }
}
