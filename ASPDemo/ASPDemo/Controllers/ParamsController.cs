using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ASPDemo.Controllers
{
    public class ParamsController : Controller
    {
        // GET: Params
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult GetMul()
        {
            int a = Int32.Parse(Request.Params["a"]);
            int b = Int32.Parse(Request.Params["b"]);
            if (a < 2)
            {
                return new HttpStatusCodeResult(403);
            }
            return Content($"{a * b}");
        }
    }
}