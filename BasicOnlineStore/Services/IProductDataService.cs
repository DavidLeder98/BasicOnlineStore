using BasicOnlineStore.Models;

namespace BasicOnlineStore.Services
{
    public interface IProductDataService
    {
        List<ProductModel> GetAllProducts();
        List<ProductModel> SearchProducts(string searchTerm);
        ProductModel GetProductById(int Id);
        int Insert(ProductModel product);
        int Delete(ProductModel product);
        int Update(ProductModel product);

    }
}
