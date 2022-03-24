using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API.Entities
{
    public class AppUser
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Phone1 { get; set; }
        public string Phone2 { get; set; }
        public string KnownAs { get; set; }
        public string EmailAddress { get; set; }
        public string Question { get; set; }
        public string Answer { get; set; }
        public bool IsTrialMode { get; set; }

    }
}