using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SounCheckPro.Controllers
{
    public class ClientController : Controller
    {
        // GET: Client
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult AddGroup()
        {
            return View();
        }
        public ActionResult SendJoinRequest()
        {
            return View();
        }
        public ActionResult JoinRequest()
        {
            return View();
        }
        public ActionResult AddVideo()
        {
            return View();
        }
    }
}