using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SounCheckPro.Controllers
{
    public class AdminController : Controller
    {
        // GET: Admin
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult AdminDashboard()
        {
            return View();
        }
        public ActionResult CheckTalent()
        {
            return View();
        }
    }
}