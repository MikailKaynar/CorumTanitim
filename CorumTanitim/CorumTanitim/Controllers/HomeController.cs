using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CorumTanitim.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult Gezilecekyerler()
        {
            return View();
        }
        public ActionResult BelediyeBaskanlarımız()
        {
            return View();
        }
        public ActionResult Tarihimiz()
        {
            return View();
        }
        public ActionResult Yemekler()
        {
            return View();
        }
    }
}