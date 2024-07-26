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
        public ActionResult<IEnumerable<ProductModel>> Index()
        {
            return repository.GetAllProducts();
        }



        [HttpGet("searchproducts/{searchTerm}")]
        public ActionResult<IEnumerable<ProductModel>> SearchProducts(string searchTerm)
        {
            return repository.SearchProducts(searchTerm);
        }



        [HttpGet("ShowOneProduct/{Id}")]
        public ActionResult<ProductModel> ShowOneProduct(int Id)
        {
            return repository.GetProductById(Id);
        }



        [HttpPost("ProcessCreate")]
        public ActionResult<int> ProcessCreate(ProductModel product)
        {
            int newId = repository.Insert(product);
            return newId;
        }



        [HttpPut("ProcessEdit")]
        public ActionResult<ProductModel> ProcessEdit(ProductModel product)
        {
            repository.Update(product);
            return repository.GetProductById(product.Id);
        }


        // - - fix later - -

        /*
        [HttpDelete("Delete/{Id}")]
        public ActionResult <> Delete(int Id)
        {

        }
        */
    }
}
