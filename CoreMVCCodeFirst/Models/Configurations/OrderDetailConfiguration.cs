using CoreMVCCodeFirst.Models.Entities;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CoreMVCCodeFirst.Models.Configurations
{
    public class OrderDetailConfiguration:BaseConfigurations<OrderDetail>
    {
        public override void Configure(EntityTypeBuilder<OrderDetail> builder)
        {
            base.Configure(builder);
            builder.Ignore(x=>x.Id);
            builder.HasKey(x=>new
            {
                x.OrderID,
                x.ProductID
            });
        }
    }
}
