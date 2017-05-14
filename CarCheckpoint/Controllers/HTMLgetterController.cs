using CarCheckpoint.BussinesLogic;
using CarCheckpoint.Models.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;


namespace CarCheckpoint.Controllers
{
    public class HTMLgetterController : Controller
    {
        public ActionResult About()
        {
            return View();
        }
        public ActionResult Contact()
        {
            return View();
        }

        [HttpPost]
        public ActionResult GetInfo(string cardnumber)
        {            
            return View(AllUserData.GetSelectedUser(cardnumber));            
        }

        public ActionResult Find()
        {
            return View();
        }
        public ActionResult GetAllUsers()
        {
            return View(Users.GetAllUsers());
        }
        public ActionResult LogIn()
        {
            return View();
        }
    }
}