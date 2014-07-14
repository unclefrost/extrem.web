using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ExtremWebMainApp.Controllers
{
    public class FooterNavigationController : Controller
    {
        //
        // GET: /FooterNavigation/

        public ActionResult ClubLeadership()
        {
            return View();
        }

        public ActionResult OurCoordinates()
        {
            return View();
        }

        public ActionResult Achievements()
        {
            return View();
        }

        public ActionResult ClubStatus()
        {
            return View();
        }

        public ActionResult LeadershipDecision()
        {
            return View();
        }

    }
}
