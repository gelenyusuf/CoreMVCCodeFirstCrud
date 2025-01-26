using CoreMVCCodeFirst.Models.Categories.ResponseModels;

namespace CoreMVCCodeFirst.Models.Categories.PageVMs
{
    public class CategoryResponsePageVM
    {
        public List<CategoryResponseModel> Categories { get; set; }
        public CategoryResponseModel Category { get; set; }
    }
}
