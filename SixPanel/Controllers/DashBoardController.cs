using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SixPanel.Controllers
{
    public class DashBoardController : Controller
    {
        // GET: DashBoard
        public ActionResult Index()
        {
            return View();
        }


        public ActionResult One()
        {
            return PartialView();
        }

        public ActionResult Two()
        {
            return PartialView();
        }

        public ActionResult Three()
        {
            return PartialView();
        }

    }
}