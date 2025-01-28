using CoreMVCCodeFirst.Models.ContextClasses;
using CoreMVCCodeFirst.Models.Entities;
using CoreMVCCodeFirst.Models.Products;
using Microsoft.AspNetCore.Mvc;

namespace CoreMVCCodeFirst.Controllers
{
    public class Product1Controller : Controller
    {
        MyContext _db;
        public Product1Controller(MyContext db)
        {
            _db = db;
                
        }
        public IActionResult GetProducts()
        {
            ProductPageVM pvm = new() { 
            
            Products = _db.Products.ToList()
            };
            return View(pvm);
        }
        public IActionResult CreateProduct() {

            ProductPageVM pvm = new()
            {

                Categories = _db.Categories.ToList()
            };

            return View(pvm);
        }
        [HttpPost]
        public IActionResult CreateProduct(Product product) {

            _db.Products.Add(product);
            _db.SaveChanges();
            return RedirectToAction("GetProducts");
        }
        public IActionResult UpdateProduct(int id) {

            ProductPageVM pvm = new()
            {

                Categories = _db.Categories.ToList(),
                Product = _db.Products.Find(id)
            };
            return View(pvm);
            }
        [HttpPost]
        public IActionResult UpdateProduct(Product product)
        {

            Product originalProduct = _db.Products.Find(product.Id);
            originalProduct.ProductName = product.ProductName;
            originalProduct.UnitPrice = product.UnitPrice;
            originalProduct.CategoryID = product.CategoryID;
            _db.SaveChanges();
            return RedirectToAction("GetProducts");
        }

        public IActionResult Delete(int id)
        {

            _db.Products.Remove(_db.Products.Find(id));
            _db.SaveChanges();
            return RedirectToAction("GetProducts");
        }
    }
}
