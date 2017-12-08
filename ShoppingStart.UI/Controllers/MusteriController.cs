using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ShoppingStart.UI.Controllers
{
    [AuthorizationUser]
    public class MusteriController : Controller
    {
        // GET: Musteri
        public ActionResult Payment()
        {
            return View();
        }
        public ActionResult Order()
        {
            return View();
        }
    }
}