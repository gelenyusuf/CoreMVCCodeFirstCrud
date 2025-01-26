using CoreMVCCodeFirst.Models.Enums;
using System.Data;

namespace CoreMVCCodeFirst.Models.Entities
{
    public abstract class BaseEntitiy
    {
        public BaseEntitiy()
        {
            CreatedDate = DateTime.UtcNow;
            Status = DataStatus.Inserted;
        }
        public int Id { get; set; }
        public DateTime CreatedDate{ get; set; }

        public DateTime?  ModifiedDate{ get; set; }

        public DateTime? DeletedDate{ get; set; }

        public  DataStatus Status{ get; set; }
    }
}
