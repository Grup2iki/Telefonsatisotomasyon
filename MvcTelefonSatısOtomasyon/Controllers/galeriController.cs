using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using MvcTelefonSatısOtomasyon.Models.Siniflar;
using System.Web.Mvc;

namespace MvcTelefonSatısOtomasyon.Controllers
{
    public class galeriController : Controller
    {
        // GET: galeri
        Context c=new Context();
        public ActionResult Index()
        {
            var degerler = c.Uruns.ToList();
            return View(degerler);
        }
    }
}