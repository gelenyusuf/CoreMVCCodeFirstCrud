﻿namespace CoreMVCCodeFirst.Models.Entities
{
    public class Category:BaseEntitiy
    {
        public string CategoryName { get; set; }
        public string Description { get; set; }

        //Relational Properties

        public virtual ICollection<Product> Products { get; set; }
    }
}
