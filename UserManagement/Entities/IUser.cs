using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UserManagement.Entities
{
    public interface IUser
    {
         string emailId { get; set; }

         string firstName { get; set; }

         int Id { get; set; }

         string lastName { get; set; }

         string phoneNumber { get; set; }

        bool DeleteById(int id);

        UserTable SelectById(int id);

        bool UpdateFirstName(int id, string newName);
    }
}
