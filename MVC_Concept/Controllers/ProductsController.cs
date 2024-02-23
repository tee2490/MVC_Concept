using Microsoft.AspNetCore.Mvc;
using MVC_Concept.Models;
using MVC_Concept.Services;

namespace MVC_Concept.Controllers
{
    public class ProductsController : Controller
    {
        private readonly IProductService productService;

        public ProductsController(IProductService productService)
        {
            this.productService = productService;
        }

        public IActionResult Index()
        {
            return View(productService.GetProduct());
        }

        public IActionResult Index1()
        {
            return View(productService.GetProduct());
        }

        public IActionResult Create()
        {
            var p = productService.GetProduct().First();
            var product = new Product 
            { 
                Id= p.Id+1,
                Name="Test",
                Price=1,
                Amount=1,
            };

            return View(product);
        }

        [HttpPost]
        public IActionResult Create(Product product)
        {
            productService.AddProduct(product);
            return RedirectToAction("Index");
        }

        public IActionResult Edit(int Id)
        {
            var product=productService.FindProduct(Id);
            return View(product);
        }

        [HttpPost]
        public IActionResult Edit(Product product)
        {
            productService.UpdateProduct(product);
            return RedirectToAction("Index");
        }

        public IActionResult Delete(int Id)
        {
            productService.DeleteProduct(Id);
            return RedirectToAction("Index");
        }

    }
}
