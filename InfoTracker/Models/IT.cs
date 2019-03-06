using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace InfoTracker.Models
{ 
    public class IT
    {
        public string Name { get; set; }
        public int ID { get; set; }
        public string Date { get; set; } 

        //Personal Info
        public string Email { get; set; }
        public bool Phonenumber { get; set; }
        public bool HomeAdd { get; set; }
        public bool DOB { get; set; }

        //Government IDs
        public bool PassportDetails { get; set; }
        public bool DriversLicense { get; set; }
        public bool SSN { get; set; }

        //Financial IDs
        public bool Card { get; set; }
        public string CardLast4digits { get; set; }
        public bool Check { get; set; }
        public bool Cash { get; set; }

        public string OwnerID { get; set; }

    }
}