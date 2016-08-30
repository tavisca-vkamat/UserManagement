using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UserManagement.Entities
{
    public class User
    {
        public string emailId { get; set; }

        public string firstName { get; set; }

        public int Id { get; set; }

        public string lastName { get; set; }
        public string phoneNumber { get; set; }
    }
}
