using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebApplication1.Controllers
{
    public class DefaultController : Controller
    {
        // GET: Default
        public ActionResult Index()
        {
            return View();
        }

         public ActionResult Method1(int id)
        {
            return View();
        } 

        public ActionResult first(int id=0)
        {
            ViewBag.Id = id;
            return View();

        }


    }
}