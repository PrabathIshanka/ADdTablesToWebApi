using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
//add moduls and http
using TwoTableWebAPI.Models;
using System.Net.Http;

namespace TwoTableWebAPI.Controllers
{
    public class AddTablesController : Controller
    {
        // GET: AddTables
        public ActionResult Index()
        {
            IEnumerable<JoinClass1> jc = null;
            HttpClient hc = new HttpClient();
            hc.BaseAddress =new Uri("http://localhost:44301/api/joinMultTables");

            var consumeapi = hc.GetAsync("joinMultTables");
            consumeapi.Wait();

            var Readdata = consumeapi.Result;
            if (Readdata.IsSuccessStatusCode)
            {
                var displaydata = Readdata.Content.ReadAsAsync<IList<JoinClass1>>();
                displaydata.Wait();
                jc = displaydata.Result;
            }
            return View(jc);
        }
    }
}