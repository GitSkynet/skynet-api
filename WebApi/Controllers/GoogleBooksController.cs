using CleanArchitecture.Application.Contracts.GoogleBooksContracts;
using Microsoft.AspNetCore.Mvc;

namespace WebApi.Controllers
{
    [ApiController]
    [Route("api/googlebooks")]
    public class GoogleBooksController : Controller
    {
        private readonly IGoogleBooksApplicationService googleBooksApplicationService;

        public GoogleBooksController(IGoogleBooksApplicationService GoogleBooksApplicationService)
        {
            this.googleBooksApplicationService = GoogleBooksApplicationService;
        }

        [HttpGet]
        [Route("getVolumeByID")]
        public async Task<IActionResult> GetVolumeByID(string bookID)
        {
            var response = await googleBooksApplicationService.GetVolumeByID(bookID);
            return new ObjectResult(response);
        }

        [HttpGet]
        [Route("GetVolumesByKeyword")]
        // Get volumes from Google Books API with keyword (ex: C Sharp, JavaScript, React...)
        public async Task<IActionResult> GetVolumesByKeyword(string keywordToSearch)
        {
            var response = await googleBooksApplicationService.GetVolumesByKeyword(keywordToSearch);
            return new ObjectResult(response);
        }
    }
}
