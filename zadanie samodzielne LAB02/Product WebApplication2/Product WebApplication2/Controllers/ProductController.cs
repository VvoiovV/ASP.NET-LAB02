using Microsoft.AspNetCore.Mvc;
using Product_WebApplication2.Models;

namespace Product_WebApplication2.Controllers
{
    public class ProductController : Controller
    {
        private static List<Product> products = new List<Product>
        {
            new Product { Id = 1, Name = "Apple", Price = 1.50m, Category = "Fruit", ExpirationDate = DateTime.Now.AddMonths(1) },
            new Product { Id = 2, Name = "Milk", Price = 2.00m, Category = "Dairy", ExpirationDate = DateTime.Now.AddDays(10) }
        };
        public IActionResult Index()
        {
            return View(products);
        }

        public IActionResult Details(int id)
        {
            var product = products.FirstOrDefault(p => p.Id == id);
            if (product == null) return NotFound();
            return View(product);
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(Product product)
        {
            product.Id = products.Count + 1;
            products.Add(product);
            return RedirectToAction("Index");
        }

        public IActionResult Edit(int id)
        {
            var product = products.FirstOrDefault(p => p.Id == id);
            if (product == null) return NotFound();
            return View(product);
        }

        [HttpPost]
        public IActionResult Edit(Product updatedProduct)
        {
            var product = products.FirstOrDefault(p => p.Id == updatedProduct.Id);
            if (product == null) return NotFound();

            product.Name = updatedProduct.Name;
            product.Price = updatedProduct.Price;
            product.Category = updatedProduct.Category;
            product.ExpirationDate = updatedProduct.ExpirationDate;

            return RedirectToAction("Index");
        }
    }
}

