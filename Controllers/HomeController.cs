namespace docker_aspnetcore_demo.Controllers
{
    using Microsoft.AspNet.Mvc;
    using Models;

    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View(this.GetUser());
        }

        public User GetUser()
        {
            User user = new User()
            {
                Name = "My name",
                Address = "My address"
            };

            return user;
        }
    }
}
