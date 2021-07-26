using MVCTutorial.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCTutorial.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            //List<string> names = new List<string>
            //{
            //    "Jeremy",
            //    "Valaree",
            //    "Adalyn"
            //};
            User user = new User();
            user.Id = 1;
            user.firstName = "Jeremy";
            user.lastName = "Munshower";
            user.Age = 33;
            //log to txt file
            //string text = "Hello";
            //System.IO.File.WriteAllText(@"C:\Users\8 7\Desktop\TheTechAcademy-C-Sharp-Projects\Logs\samplelog.txt", text);
            //Random rndm = new Random(10);
            //int num = rndm.Next();

            //ViewBag.RandomNumber = num;
            //if (num > 2000)
            //{
            //    return View("About");
            //}
            // doesnt have to be just view can return anything
            return View(user); 
            //redirtects to a different view but doesnt trigger method in {}
            //return RedirectToAction("Contact");
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";
            //throw an error instead of full page
            //throw new Exception("Invalid Page");

            return View();
        }

        //also accept paramaters
        public ActionResult Contact(int id=0)
        {
            ViewBag.Message = id;

            return View();
        }
    }
}