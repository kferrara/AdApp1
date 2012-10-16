using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using AdApp1.Models;
using AdApp1.ViewModels;

namespace AdApp1.Controllers
{
    public class HomeController : Controller
    {
        private readonly AdApp1Db db = new AdApp1Db();

        //
        // GET: /Home/
        public ActionResult Index()
        {
            return View();
        }

        protected override void Dispose(bool disposing)
        {
            db.Dispose();
            base.Dispose(disposing);
        }
    }
}
