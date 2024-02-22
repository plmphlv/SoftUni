using Microsoft.AspNetCore.Mvc;

namespace ASPNetCoreMVCIntro.Controllers
{
    public class NumberController : Controller
    {
        private readonly ILogger logger;

        public NumberController(ILogger<NumberController> _logger)
        {
            logger = _logger;
        }

        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public IActionResult PrintNumbers(int num = 3)
        {
            return View(num);
        }
    }
}
