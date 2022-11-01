using Microsoft.AspNetCore.Mvc;
using PoorReddit.Models;
using System.Diagnostics;

namespace PoorReddit.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        
        RedditDAL api = new RedditDAL();

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult ShowPost()
        {
            AwwAPI apv = api.GetPosts();
            /*AllPropsViewModel apv = new AllPropsViewModel();
            apv.Aww = Aww;
            
            List<Child> childItems = api.ConvertChildren();*/
            return View(apv);

            /*string[] permalink = sp.homeworld.Split("/");
            int planetId = int.Parse(homeURL[5]);
            p.World = api.GetPosts(planetId);
            p.PlanetId = planetId;*/

         }


        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}