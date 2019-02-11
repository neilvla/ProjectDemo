using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using ProjectDemo.Models;

namespace ProjectDemo.Controllers
{
    public class DemoController : Controller
    {
        IHostingEnvironment _env;

        public DemoController(IHostingEnvironment env)
        {
            _env = env;
        }
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult NewPage()
        {
            User u = null;
            if (_env.IsDevelopment())
            {
                u = new User
                {
                    Id = 1,
                    Name = "Alexis",
                    LastName = "García"
                };
            }
            if (_env.IsStaging())
            {
                u = new User
                {
                    Id = 2,
                    Name = "Pavel",
                    LastName = "Padilla"
                };
            }
            if (_env.IsProduction())
            {
                u = new User
                {
                    Id = 3,
                    Name = "Andrez",
                    LastName = "Otiniano"
                };
            }

            return View(u);
        }
    }
}