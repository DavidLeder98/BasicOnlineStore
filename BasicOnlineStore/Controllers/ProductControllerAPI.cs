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
        public ActionResult<IEnumerable<ProductModelDTO>> Index()
        {
            List<ProductModel> products = repository.GetAllProducts();

            List<ProductModelDTO> productDTOs = new List<ProductModelDTO>();

            foreach (var p in products)
            {
                productDTOs.Add( new ProductModelDTO(p) );
            }

            return productDTOs;
        }



        [HttpGet("searchproducts/{searchTerm}")]
        public ActionResult<IEnumerable<ProductModel>> SearchProducts(string searchTerm)
        {
            return repository.SearchProducts(searchTerm);
        }



        [HttpGet("ShowOneProduct/{Id}")]
        public ActionResult<ProductModelDTO> ShowOneProduct(int Id)
        {
            ProductModel p = repository.GetProductById(Id);
            ProductModelDTO pDTO = new ProductModelDTO(p);

            return pDTO;
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
