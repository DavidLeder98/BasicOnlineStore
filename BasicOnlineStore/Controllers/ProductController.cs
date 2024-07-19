using BasicOnlineStore.Models;
using BasicOnlineStore.Services;
using Bogus;
using Microsoft.AspNetCore.Mvc;

namespace BasicOnlineStore.Controllers
{
    public class ProductController : Controller
    {
        public IActionResult Index()
        {
            HardCodedSampleDataRepository hardCodedSampleDataRepository = new HardCodedSampleDataRepository();

            return View(hardCodedSampleDataRepository.GetAllProducts());
        }
    }
}
