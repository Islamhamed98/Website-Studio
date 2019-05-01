using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using SecondTaskSupportWebCrew.Models;


namespace SecondTaskSupportWebCrew.Controllers
{
    public class AdminController : Controller
    {
        //
        // GET: /Admin/

        protected ApplicationDbContext _context;
        public AdminController()
        {
            _context = new ApplicationDbContext();
        }

        public ActionResult Index()
        {
            var data = _context.Session.ToList();
            return View(data);
        }

        public ActionResult Add()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Add(Session NewSession)
        {
            _context.Session.Add(NewSession);
            _context.SaveChanges();
            return RedirectToAction("Index");
        }

        // Get Admin/Edit/id 
        public ActionResult Edit(int id)
        {
            Session _product = _context.Session.Find(id);
            if (_product == null)
                return HttpNotFound();
            return View(_product);
        }


        // post admin/edit/id  
        [HttpPost]
        public ActionResult Edit(int id, Session Edited_Session)
        {
            var modifiedSession = _context.Session.Find(id);

            try
            {
                modifiedSession.Location = Edited_Session.Location;
                modifiedSession.Price = Edited_Session.Price;
                modifiedSession.Description = Edited_Session.Description;
                modifiedSession.Image = Edited_Session.Image;
                modifiedSession.City = Edited_Session.City;
                modifiedSession.Photgrapher = Edited_Session.Photgrapher;
                _context.SaveChanges();
                return RedirectToAction("index");
            }
            catch
            {
                return View();
            }

        }

        public ActionResult Delete(int id)
        {
            try
            {
                Session _session = _context.Session.Find(id);
                if (_session == null)
                    return HttpNotFound();

                _context.Session.Remove(_session);
                _context.SaveChanges();
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }

        }

        


	
    }
}   