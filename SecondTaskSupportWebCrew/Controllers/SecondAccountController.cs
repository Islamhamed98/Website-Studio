using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using SecondTaskSupportWebCrew.Models;

namespace SecondTaskSupportWebCrew.Controllers
{
    public class SecondAccountController : Controller
    {
        //
        // GET: /SecondAccount/

        public ApplicationDbContext _context;
        public SecondAccountController()
        {
            _context = new ApplicationDbContext();
        }
        // Get Controller/Action/Id
        public ActionResult EditProfile(int id)
        {
           string password = "";
           if (Session["password"] == null)
               return HttpNotFound();
           else
               password = Session["password"].ToString();
           var customer = _context.Customer.SingleOrDefault(s => s.Password == password);
           return View(customer);
        }
        [HttpPost] 
        public ActionResult EditProfile(int id , Customer customer)
        {
            var ModifiedCustomer = _context.Customer.Find(id);
            try
            {
                ModifiedCustomer.Name = customer.Name;
                ModifiedCustomer.Name.Trim();
                ModifiedCustomer.Password = customer.Password;
                ModifiedCustomer.Password.Trim();
                ModifiedCustomer.Email = customer.Email;
                ModifiedCustomer.Email.Trim();
                ModifiedCustomer.Gender = customer.Gender;
                ModifiedCustomer.Gender.Trim();
                _context.SaveChanges();
                return RedirectToAction("Index", "Login");
            } 
            catch
            {
                return View();
            }
        }
         

        public ActionResult Setting()
        {
            return View();
        }
       
        public ActionResult Logout()
        {
           return RedirectToAction("Index", "Login");
        }

    }
}