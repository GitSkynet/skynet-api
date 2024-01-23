using CleanArchitecture.Application.Contracts.OpenBooksContracts;
using Microsoft.AspNetCore.Mvc;
using PresentationLayer.MVC.Web.Models;
using System.Diagnostics;

namespace PresentationLayer.MVC.Web.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly IBooksApplicationService openBooksApplicationService;
        public HomeController(ILogger<HomeController> logger, IBooksApplicationService OpenBooksApplicationService)
        {
            _logger = logger;
            this.openBooksApplicationService = OpenBooksApplicationService;
        }

        public async Task<IActionResult> Index()
        {
            var response = await openBooksApplicationService.GetBookByID(5040);
            return View(response);
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