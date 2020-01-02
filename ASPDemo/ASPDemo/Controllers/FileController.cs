using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ASPDemo.Controllers
{
    public class FileController : Controller
    {
        // GET: File
        public ActionResult Index()
        {
            return View();
        }

        public FileResult GetFile()
        {
            string filePath = Server.MapPath("~/Files/aurora_borealis.png");
            string fileType = "image";
            string fileName = "aurora_borealis.png";
            return File(filePath, fileType, fileName);
        }
    }
}