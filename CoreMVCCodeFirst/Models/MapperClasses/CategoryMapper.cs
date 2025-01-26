using CoreMVCCodeFirst.Models.Categories.ResponseModels;
using CoreMVCCodeFirst.Models.Entities;
using CoreMVCCodeFirst.Models;
using CoreMVCCodeFirst.Models.Categories.PureVM;
namespace CoreMVCCodeFirst.Models.MapperClasses
{
    public static class CategoryMapper
    {
        public static CategoryResponseModel GetCategoryResponseModel(Category category)
        {
            return new()
            {
                ID = category.Id,
                CategoryName = category.CategoryName,
                Description = category.Description
            };
        }

        public static CategoryVM GetCategoryVM(Category category)
        {
            return new()
            {
                ID = category.Id,
                CategoryName = category.CategoryName,
                Description = category.Description
            };
        }
    }
}
