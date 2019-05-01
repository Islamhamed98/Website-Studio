using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using SecondTaskSupportWebCrew.Models;

namespace SecondTaskSupportWebCrew.Controllers
{
    public class ProductController : Controller
    {
        protected ApplicationDbContext _context; 
        
        public ProductController ()
        {
            _context = new ApplicationDbContext();
        }

        //
        // GET: /Product/
        public ActionResult Index()
        {
            var data = _context.Product.ToList();
            
            return View(data);
        }


	}
}