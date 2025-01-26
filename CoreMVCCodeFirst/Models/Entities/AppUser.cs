namespace CoreMVCCodeFirst.Models.Entities
{
    public class AppUser:BaseEntitiy
    {

        public string UserName { get; set; }
        public string Password { get; set; }

        //Relational Properties

        public virtual AppUserProfile Profiles { get; set; }

        public virtual ICollection<Order> Orders { get; set; }
    }
}
