using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using SecondTaskSupportWebCrew.Models;

namespace SecondTaskSupportWebCrew.Controllers
{
    public class RegisterController : Controller
    {
        //
        // GET: /Register/
        public ActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Index(FormCollection GetData)
        {
            try
            {
                Customer newCustomer = new Customer();
                newCustomer.Name = GetData["username"];
                newCustomer.Name.Trim();
                newCustomer.Password = GetData["password"];
                newCustomer.Password.Trim();
                newCustomer.Gender = GetData["gender"];
                newCustomer.Gender.Trim();
                newCustomer.Email = GetData["email"];
                newCustomer.Email.Trim();
                ApplicationDbContext dp = new ApplicationDbContext();
                dp.Customer.Add(newCustomer);
                dp.SaveChanges();
                return RedirectToAction("Index", "Login");

            } catch(Exception e){
                throw e;
            }
            
            

            return View();
        }

        





	}
}