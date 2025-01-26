﻿namespace CoreMVCCodeFirst.Models.Entities
{
    public class OrderDetail : BaseEntitiy
    {
        public int  OrderID { get; set; }
        public int ProductID { get; set; }

        //Relational Properties

        public virtual Order Order { get; set; }

        public virtual Product Product { get; set; }
    }
}
