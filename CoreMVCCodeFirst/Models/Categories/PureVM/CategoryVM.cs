using Microsoft.AspNetCore.Mvc.RazorPages;

namespace CoreMVCCodeFirst.Models.Categories.PureVM
{
    public class CategoryVM
    {
        public  int ID { get; set; }
        public string CategoryName { get; set; }
        public string Description { get; set; }
    }
}
