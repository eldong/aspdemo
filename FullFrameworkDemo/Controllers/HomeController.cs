using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;

namespace FullFrameworkDemo.Controllers
{
    public class HomeController : Controller
    {
        HttpClient client;

        public HomeController()
        {
            client = new HttpClient();
        }

        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        //public async Task<IActionResult> Quotes()
        public async Task<ViewResult> Quotes()
        {
            ViewBag.Message = "Your contact page.";

            var response = await client.GetStringAsync("https://localhost:44317/api/quotes");
            //var sessions = JsonConvert.DeserializeObject&amp;lt;List&amp;lt;Session&amp;gt;&amp;gt;(response);
            ViewData["Message"] = response; //""Quotes";

            return (ViewResult)View();
        }
    }
}