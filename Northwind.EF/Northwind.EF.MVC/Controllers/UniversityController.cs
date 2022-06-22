using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Net.Http;
using System.Web.Script.Serialization;
using Northwind.EF.MVC.Models;

namespace Northwind.EF.MVC.Controllers
{
    public class UniversityController : Controller
    {
        static HttpClient client = new HttpClient();

        // GET: University
        public ActionResult Index()
        {
            List<UniversityView> universitiesView = new List<UniversityView>();
            var response = client.GetAsync("http://universities.hipolabs.com/search?country=Argentina");
            response.Wait();
            var result = response.Result;

            if (result.IsSuccessStatusCode)
            {
                var data = result.Content.ReadAsStringAsync();
                data.Wait();

                JavaScriptSerializer JSserializer = new JavaScriptSerializer();
                var universities = JSserializer.Deserialize<List<dynamic>>(data.Result);

                foreach(var university in universities)
                {
                    universitiesView.Add(new UniversityView
                    {
                        WebPages = university["web_pages"][0], // Solo nos interesa la primera pagina web de la universidad
                        StateProvince = university["state-province"],
                        Name = university["name"],
                        Country = university["country"],
                    });
                }
            }
            return View(universitiesView);
        }
    }
}