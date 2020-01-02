using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace ASPDemo.Controllers
{
    public class ShowController : IController
    {
        public void Execute(RequestContext requestContext)
        {
            string browser = requestContext.HttpContext.Request.Browser.Browser;
            var response = requestContext.HttpContext.Response;
            response.Write($"<h2>Your browser: {browser}</h2>");
        }
    }
}