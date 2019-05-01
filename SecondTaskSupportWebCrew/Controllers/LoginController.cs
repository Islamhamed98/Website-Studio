using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using SecondTaskSupportWebCrew.Models; 
 

namespace SecondTaskSupportWebCrew.Controllers
{
    public class LoginController : Controller 
    {

        protected ApplicationDbContext _context ;
        public LoginController () 
        {
            _context = new ApplicationDbContext();        
        }
        //
        // GET: /Login/

        public ActionResult Index()
        {
            return View();
        }
        public ActionResult admin()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Index(FormCollection MyCollectionDataFromMyForm)
        {
            string username = MyCollectionDataFromMyForm["username"];
            string password = MyCollectionDataFromMyForm["password"];
         
            Session["username"] = username;
            Session["password"] = password;
            
            var user = _context.Customer.SingleOrDefault(c => c.Password == password);
            if (user == null) 
                return View();
            Session["Id"] = user.Id;
            if(user.AdminRole == 1)
            {
                if(user.Name == username)
                     return RedirectToAction("Index", "Home");
            }
            else 
            {
                if (user.Name == username)
                     return RedirectToAction("Index", "Home");
                
            }
            return View();
        }





	}
}