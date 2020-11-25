using Microsoft.AspNetCore.Mvc;
using CIC_EP.Web.Controllers;

namespace CIC_EP.Web.Public.Controllers
{
    public class HomeController : CIC_EPControllerBase
    {
        public ActionResult Index()
        {
            return View();
        }
    }
}