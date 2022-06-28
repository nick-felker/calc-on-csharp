using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using System.Diagnostics;
using Calculate.Plant;
using WebCalc.Models;
using WindowsFormsApp2;


namespace WebCalc.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
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
        public ActionResult Index()
        {
            ViewBag.Operation = new SelectListItem[]
            {
                 new SelectListItem() { Value = "multiply", Text ="multiply" },
                 new SelectListItem() { Value = "sum", Text ="sum" },
                 new SelectListItem() { Value = "minus", Text ="minus" },
                 new SelectListItem() { Value = "division", Text ="division" }
            };
            return View();
        }
        [HttpPost]
        public ActionResult Index(
            double firstNumber,
            double secondNumber,
            string operation
        )
        {
            ITwoArgumentsCalculator calculator = TwoArgFactory.CreateCalculator(operation);
            double result = calculator.Calculate(firstNumber, secondNumber);
            ViewBag.Result = result;
            ViewBag.Operation = new SelectListItem[]
            {
                new SelectListItem() { Value = "multiply", Text ="multiply" },
                new SelectListItem() { Value = "sum", Text ="sum" },
                new SelectListItem() { Value = "minus", Text ="minus" },
                new SelectListItem() { Value = "division", Text ="division" }
            };
            return View();
        }
    }
}