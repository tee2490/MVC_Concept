using MVC_Concept.Models;

namespace MVC_Concept.Services
{
    public class ProductService : IProductService
    {
        public List<Product> products;

        public ProductService()
        {
            products = new List<Product>();
            GenerateProduct(100);
        }

        public void GenerateProduct(int number = 10)
        {
            for (int i = 1; i <= number; i++)
            {
                Random random = new Random();
                products.Add(new Product
                {
                    Id = i,
                    Name = $"Product{i}",
                    Price = random.NextDouble() * 100 + 1,
                    Amount = random.Next(100) + 1
                }); ;
            }
        }

        public IEnumerable<Product> GetProduct()
        {
            return products.OrderByDescending(p=>p.Id);
        }

        public void AddProduct(Product product)
        {
            products.Add(product);
        }

        public Product FindProduct(int Id)
        {
            return products.Find(x => x.Id == Id);
        }

        public void UpdateProduct(Product product)
        {
            var p=products.Find(x => x.Id == product.Id);
            if (p == null) return;

            var index = products.IndexOf(p);
            products.RemoveAt(index);
            products.Insert(index, product);
        }

        public void DeleteProduct(int Id)
        {
            var p = products.Find(x => x.Id == Id);
            if (p == null) return;

            var index = products.IndexOf(p);
            products.RemoveAt(index);
        }

    }
}
