using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using System.ComponentModel.DataAnnotations;
using InfoTracker.Models;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace InfoTracker.ViewModels
{
    public class EditITViewModel
    {

        public int ID { get; set; }

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

        public EditITViewModel() { }

        public EditITViewModel(IT it)
        {
            ID = it.ID;
            Name = it.Name;
            Date = it.Date;
            Email = it.Email;
            Phonenumber = it.Phonenumber;
            HomeAdd = it.HomeAdd;
            DOB = it.DOB;
            PassportDetails = it.PassportDetails;
            DriversLicense = it.DriversLicense;
            SSN = it.SSN;
            Card = it.Card;
            CardLast4digits = it.CardLast4digits;
            Check = it.Check;
            Cash = it.Cash;


        }
    }
}

