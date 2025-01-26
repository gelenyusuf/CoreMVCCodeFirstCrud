namespace CoreMVCCodeFirst.Models.Entities
{
    public class Order : BaseEntitiy
    {
        public string ShippingAddress { get; set; }

        public int? AppUserID { get; set; }

        //Relational Properties

        public virtual AppUser AppUser { get; set; }
        public virtual ICollection<OrderDetail> OrderDetails { get; set; }
    }
}
