using MVC_Example1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVC_Example1.Controllers
{
    public class OUController : Controller
    {
        // GET: OU
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult TAs()
        {
            List<Student> tas = new List<Student>()
            {
                new Student()
                {
                    FirstName = "Micah",
                    LastName = "Tison",
                    SoonerID = 5
                },
                new Student()
                {
                    FirstName = "Talia",
                    LastName = "Dean",
                    SoonerID = 25
                }
            };



            return View(tas);
        }
    }
}