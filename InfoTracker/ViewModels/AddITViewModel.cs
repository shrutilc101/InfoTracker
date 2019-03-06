using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using InfoTracker.Models;

namespace InfoTracker.ViewModels
{
    public class AddITViewModel
    {
        [Required]
        [Display(Name = "Name")]
        public string Name { get; set; }

        [Required]
        [Display(Name = "Date")]
        public string Date { get; set; }

        [Display(Name = "Email")]
        public string Email { get; set; }

        [Display(Name = "Phone No.")]
        public bool Phonenumber { get; set; }

        [Display(Name = "Home Add.")]
        public bool HomeAdd { get; set; }

        [Display(Name = "Date of Birth")]
        public bool DOB { get; set; }

        //Government IDs
        [Display(Name = "Passport Number")]
        public bool PassportDetails { get; set; }

        [Display(Name = "DriversLicense")]
        public bool DriversLicense { get; set; }

        [Display(Name = "SSN")]
        public bool SSN { get; set; }

        //Financial IDs
        [Display(Name = "Credit Card")]
        public bool Card { get; set; }

        [Display(Name = "Last 4 Digits")]
        public string CardLast4digits { get; set; }

        [Display(Name = "Check")]
        public bool Check { get; set; }

        [Display(Name = "Cash")]
        public bool Cash { get; set; }


    }
}
