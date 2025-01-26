using CoreMVCCodeFirst.Models.Categories.PageVMs;
using CoreMVCCodeFirst.Models.Categories.PureVM;
using CoreMVCCodeFirst.Models.Categories.RequestModels;
using CoreMVCCodeFirst.Models.Categories.ResponseModels;
using CoreMVCCodeFirst.Models.ContextClasses;
using CoreMVCCodeFirst.Models.Entities;
using CoreMVCCodeFirst.Models.MapperClasses;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore.Query.SqlExpressions;

namespace CoreMVCCodeFirst.Controllers
{
    public class CategoryController : Controller
    {
        MyContext _db;
        public CategoryController(MyContext db)
        {
            _db = db;
        }
        public IActionResult CreateCategory()
        {
            return View();
        }
        [HttpPost]
        public IActionResult CreateCategory(CreateCategoryRequestModel category)
        {
            Category c = new()
            {
            CategoryName= category.CategoryName,
            Description = category.Description
            };
            _db.Categories.Add(c);
            _db.SaveChanges();
            return RedirectToAction("GetCategories");
        }
        public IActionResult GetCategories() {

            List<CategoryResponseModel> categories = _db.Categories.Select(x => new CategoryResponseModel
            {
                CategoryName = x.CategoryName,
                Description
            = x.Description
            }).ToList();
            CategoryResponsePageVM cpvm = new CategoryResponsePageVM()
            {
                Categories = categories
            };
            return View(cpvm);
        }
        public IActionResult UpdateCategory(int id)
        {

            CategoryVM category = CategoryMapper.GetCategoryVM(_db.Categories.Find(id));

            CategorySharedPageVm cpVm = new()
            {
                Category = category
            };

            return View(cpVm);
        }


        [HttpPost]
        public IActionResult UpdateCategory(CategoryVM category)
        {
            Category original = _db.Categories.Find(category.ID);
            original.CategoryName = category.CategoryName;
            original.Description = category.Description;
            _db.SaveChanges();
            TempData["message"] = "Guncelleme basarılı";
            return RedirectToAction("GetCategories");
        }
        public IActionResult DeleteCategory(int id)
        {
            _db.Categories.Remove(_db.Categories.Find(id));
            _db.SaveChanges();
            return RedirectToAction("GetCategories");
        }
    }
}
