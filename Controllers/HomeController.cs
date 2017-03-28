using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Proyecto.Models;

namespace Proyecto.Controllers
{
    public class HomeController : Controller
    {
        private ProyectoEntities db = new ProyectoEntities();

        public ActionResult Index()
        {
            return View();
        }
    }
}