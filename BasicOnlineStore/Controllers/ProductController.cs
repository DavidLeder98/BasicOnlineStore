using BasicOnlineStore.Models;
using Bogus;
using Microsoft.AspNetCore.Mvc;

namespace BasicOnlineStore.Controllers
{
    public class ProductController : Controller
    {
        public IActionResult Index()
        {
            List<ProductModel> productsList = new List<ProductModel>();

            productsList.Add(new ProductModel { Id = 1, Name = "Ooga", Price = 11.11m, Description = "Booga"});
            productsList.Add(new ProductModel { Id = 2, Name = "Jeffery", Price = 22.11m, Description = "Epstein" });
            productsList.Add(new ProductModel { Id = 3, Name = "I like", Price = 11.31m, Description = "cheese" });
            productsList.Add(new ProductModel { Id = 4, Name = "I dont like", Price = 88.88m, Description = "sand" });

            for(int i = 0; i < 100; i++)
            {
                productsList.Add(new Faker<ProductModel>()
                    .RuleFor(p => p.Id, i + 5)
                    .RuleFor(p => p.Name, f => f.Commerce.ProductName())
                    .RuleFor(p => p.Price, f => f.Random.Decimal(100))
                    .RuleFor(p => p.Description, f => f.Rant.Review())
                    );
            }

            return View(productsList);
        }
    }
}
