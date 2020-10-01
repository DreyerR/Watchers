using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Watchers.Models
{
    class GetUserResponse
    {
        public bool IsSuccessful { get; set; }
        public List<User> Users { get; set; }
    }

    class User
    {
        public int UserID { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Email { get; set; }
        public bool IsAdmin { get; set; }
    }
}
