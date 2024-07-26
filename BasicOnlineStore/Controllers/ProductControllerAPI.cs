using BasicOnlineStore.Models;
using BasicOnlineStore.Services;
using Bogus;
using Microsoft.AspNetCore.Mvc;
using NuGet.Protocol.Core.Types;

namespace BasicOnlineStore.Controllers
{
    [ApiController]
    [Route("api/")]
    public class ProductControllerAPI : ControllerBase
    {
        ProductsDAO repository;
        public ProductControllerAPI()
        {
            repository = new ProductsDAO();
        }



        [HttpGet]
        public ActionResult <IEnumerable<ProductModel>> Index()
        {
            return repository.GetAllProducts();
        }


        
        [HttpGet("searchproducts/{searchTerm}")]
        public ActionResult <IEnumerable<ProductModel>> SearchProducts(string searchTerm)
        {
            return repository.SearchProducts(searchTerm);
        }
        /*
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



        public IActionResult Edit(int id)
        {
            ProductsDAO products = new ProductsDAO();
            ProductModel foundProduct = products.GetProductById(id);
            return View("ShowEdit", foundProduct);
        }

        public IActionResult ProcessEdit(ProductModel product)
        {
            ProductsDAO products = new ProductsDAO();
            products.Update(product);
            return View("Index", products.GetAllProducts());
        }



        public IActionResult Delete(int id)
        {
            ProductsDAO products = new ProductsDAO();
            ProductModel product = products.GetProductById(id);
            products.Delete(product);
            return View("Index", products.GetAllProducts());
        }



        public IActionResult InsertForm()
        {
            return View();
        }

        public IActionResult ProcessCreate(ProductModel product)
        {
            ProductsDAO products = new ProductsDAO();
            products.Insert(product);
            return View("Index", products.GetAllProducts());
        }



        // - - JSON related - -

        public IActionResult ShowOneProduct(int Id)
        {
            return View(repository.GetProductById(Id));
        }

        public IActionResult ShowOneProductJSON(int Id)
        {
            return Json(repository.GetProductById(Id));
        }

        public IActionResult ProcessEditReturnPartial(ProductModel product)
        {
            repository.Update(product);
            return PartialView("_productCard", product);
        }*/
    }
}
