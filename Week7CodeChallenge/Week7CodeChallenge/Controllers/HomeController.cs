using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Week7CodeChallenge.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            if (Request.IsAjaxRequest())
            {
                return PartialView();
            }
            else { return View(); }
        }
        public ActionResult About()
        {
            if (Request.IsAjaxRequest())
            {
                return PartialView();
            }
            else { return View(); }
        }
        public ActionResult Work()
        {
            if (Request.IsAjaxRequest())
            {
                return PartialView();
            }
            else { return View(); }
        }
        public ActionResult Careers()
        {
            if (Request.IsAjaxRequest())
            {
                return PartialView();
            }
            else { return View(); }
        }
        [HttpGet]
        public ActionResult Contact()
        {
            Models.ContactPageForms contactForm = new Models.ContactPageForms();
            return PartialView();
        }
        [HttpPost]
        public ActionResult Contact(Models.ContactPageForms contactForm)
        {
            Models.sp6EugeneEntities db = new Models.sp6EugeneEntities();
            db.ContactPageForms.Add(contactForm);
            db.SaveChanges();
            return Content("Thanks!");
        }
        public ActionResult Who()
        {
            return PartialView();
        }
        public ActionResult What()
        {
            return PartialView();
        }
        public ActionResult When()
        {
            return PartialView();
        }
        public ActionResult Where()
        {
            return PartialView();
        }
        public ActionResult How()
        {
            return PartialView();
        }
    }
    }