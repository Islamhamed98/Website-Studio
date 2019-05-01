using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using SecondTaskSupportWebCrew.Models;

namespace SecondTaskSupportWebCrew.Controllers
{
    public class SessionController : Controller
    {
        protected ApplicationDbContext _context; 
        
        public SessionController ()
        {
            _context = new ApplicationDbContext();
        }

        //
        // GET: /Product/
        public ActionResult Index()
        {
            var data = _context.Session.ToList();
           
            return View(data);
        }


	}
}