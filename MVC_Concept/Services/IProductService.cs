using MVC_Concept.Models;

namespace MVC_Concept.Services
{
    public interface IProductService
    {
        void GenerateProduct(int number);
        IEnumerable<Product> GetProduct();
        void AddProduct(Product product);
        void UpdateProduct(Product product);
        void DeleteProduct(int Id);
        Product FindProduct(int Id);
    }
}
