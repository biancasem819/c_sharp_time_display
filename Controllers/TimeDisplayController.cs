using Microsoft.AspNetCore.Mvc;
namespace TimeDisplay.Controllers     //be sure to use your own project's namespace!
{
    public class TimeDisplayController : Controller 
    {
        //for each route this controller is to handle:
        [HttpGet("")]       
        public ViewResult Index()
        {
            return View();
        }
    }
}