using System.Collections.Generic;
using System.Web.Mvc;
using KendoGridDemo.Models;
using Newtonsoft.Json;

namespace KendoGridDemo.Controllers
{
    public class HomeController : Controller
    {
        [HttpGet]
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost, ValidateInput(false)]
        public ActionResult Index(string Comments)
        {

            var cmntData = JsonConvert.DeserializeObject<List<ResponseComments>>(Comments);
            return View();
        }
        //public ActionResult About()
        //{
        //    ViewBag.Message = "Your app description page.";

        //    return View();
        //}

        //public ActionResult Contact()
        //{
        //    ViewBag.Message = "Your contact page.";

        //    return View();
        //}
    }
}
