using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Deeksha.Models
{
    public class Contact
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string NickName { get; set; }
        public string place { get; set; }
        public DateTime DateCreated { get; set; }
        public bool IsDeleted { get; set; } = false;

        

    }
}
