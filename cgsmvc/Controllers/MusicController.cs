using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace cgsmvc.Controllers
{
    public class MusicController : Controller
    {
        // GET: Musics
        public ActionResult Index()
        {
            return View();
        }
    }
}