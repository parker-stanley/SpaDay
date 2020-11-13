using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using SpaDay.Models;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace SpaDay.Controllers
{
    public class UserController : Controller
    {
        // GET: /<controller>/
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Add()
        {
            return View();
        }

        //original attempt, requires if statement on add but could easily delete tempUser later
        //public IActionResult SubmitAddUserForm(User newUser, string verify)
        //{
        //    if(newUser.Password == verify)
        //    {
        //        ViewBag.user = newUser;
        //        return View("Index");
        //    }
        //    else
        //    {
        //        ViewBag.error = "Passwords must match.";
        //        ViewBag.tempUser = newUser;
        //        return View("Add");
        //    }
        //}


        //better version that is cleaner but doesn't allow for storing and deleting user data
        public IActionResult SubmitAddUserForm(User newUser, string verify)
        {
            ViewBag.userName = newUser.Username;
            ViewBag.email = newUser.Email;
            ViewBag.dateJoined = newUser.DateJoined;

            if (newUser.Password == verify)
            {
                return View("Index");

            }
            else
            {
                ViewBag.error = "Passwords must match";
                return View("Add");
            }
        }
    }
}
