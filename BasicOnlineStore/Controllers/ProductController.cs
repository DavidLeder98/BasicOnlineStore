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
            ProductsDAO products = new ProductsDAO();

            return View(products.GetAllProducts());
        }



        public IActionResult SearchResults(string searchTerm)
        {
            ProductsDAO products = new ProductsDAO();
            List<ProductModel> productsList = products.SearchProducts(searchTerm);
            return View("index", productsList);
        }

        public IActionResult SearchForm()
        {
            return View();
        }



        public IActionResult ShowDetails(int id)
        {
            ProductsDAO products = new ProductsDAO();
            ProductModel foundProduct = products.GetProductById(id);
            return View(foundProduct);
        }
    }
}
