using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using InfoTracker.ViewModels;
using Microsoft.EntityFrameworkCore;
using InfoTracker.Data;
using InfoTracker.Models;

namespace InfoTracker.Controllers
{
    public class ITController : Controller
    {
        private ApplicationDbContext context;

        public ITController(ApplicationDbContext dbContext)
        {
            context = dbContext;
        }
        public IActionResult Index()
        {
            // get the list of all IT's that a user owns, return the View and pass in the list.
            IList<IT> names = context.ITs.ToList();
            return View(names);
        }

        [HttpGet]
        public IActionResult Add()
        {
            AddITViewModel addITViewModel = new AddITViewModel();
            // create a new, empty AddITViewModel and pass it into the view.
            return View(addITViewModel);
        }

        [HttpPost]
        public IActionResult Add(AddITViewModel addITViewModel)// pass the AddITVM from the GetForm into this Add(AddITVM called addITVM)
        {
            if (ModelState.IsValid)
            {
                IT newIT = new IT
                {
                    Name = addITViewModel.Name,
                    Date = addITViewModel.Date,
                    Email = addITViewModel.Email,
                    Phonenumber = addITViewModel.Phonenumber,
                    HomeAdd = addITViewModel.HomeAdd,
                    DOB = addITViewModel.DOB,
                    PassportDetails = addITViewModel.PassportDetails,
                    DriversLicense = addITViewModel.DriversLicense,
                    SSN = addITViewModel.SSN,
                    Card = addITViewModel.Card,
                    CardLast4digits = addITViewModel.CardLast4digits,
                    Check = addITViewModel.Check,
                    Cash = addITViewModel.Cash
                };
                context.ITs.Add(newIT);
                context.SaveChanges();
                
            }

                
                //  Model.isValid
                //  If is valid
                //  Create a new IT Object
                //  Save it to the Db.

                // If not valid
                // Redirect to the Get Form pass back the AddItVM object that they filled.
                return Redirect("/IT");
        }
        public IActionResult Remove()
        {
            ViewBag.title = "Remove";
            ViewBag.Its = context.ITs.ToList();
            return View();
        }

        [HttpPost]
        public IActionResult Remove(int[] ITIds)
        {
            foreach (int itId in ITIds)
            {
                IT theIT = context.ITs.Single(c => c.ID == itId);
                context.ITs.Remove(theIT);
            }

            context.SaveChanges();

            return Redirect("/");
        }

        public IActionResult Edit(int id)
        {
            IT theIT = context.ITs.Single(c => c.ID == id);
            EditITViewModel editITViewModel = new EditITViewModel(theIT);
            return View(editITViewModel);

        }

        [HttpPost]
        public IActionResult Edit(EditITViewModel editITViewModel)
        {
            if (ModelState.IsValid)
            { 

                IT theIT = context.ITs.Single(c => c.ID == editITViewModel.ID);


                theIT.Name = editITViewModel.Name;
                theIT.Date = editITViewModel.Date;
                theIT.Email = editITViewModel.Email;
                theIT.Phonenumber = editITViewModel.Phonenumber;
                theIT.HomeAdd = editITViewModel.HomeAdd;
                theIT.DOB = editITViewModel.DOB;
                theIT.PassportDetails = editITViewModel.PassportDetails;
                theIT.DriversLicense = editITViewModel.DriversLicense;
                theIT.SSN = editITViewModel.SSN;
                theIT.Card = editITViewModel.Card;
                theIT.CardLast4digits = editITViewModel.CardLast4digits;
                theIT.Check = editITViewModel.Check;
                theIT.Cash = editITViewModel.Cash;
                

                context.ITs.Update(theIT);
                context.SaveChanges();
                return Redirect("/IT");

            }
            else
            {
                return View(editITViewModel);
            }

        }

    }
}