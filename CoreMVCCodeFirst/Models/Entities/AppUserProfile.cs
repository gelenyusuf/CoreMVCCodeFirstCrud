namespace CoreMVCCodeFirst.Models.Entities
{
    public class AppUserProfile:BaseEntitiy
    {
        public string FirstName{ get; set; }
        public string LastName { get; set; }

        //Relational Properties

        public virtual  AppUser AppUser { get; set; }
    }
}
