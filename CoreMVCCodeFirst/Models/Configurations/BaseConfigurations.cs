using Microsoft.EntityFrameworkCore;
using CoreMVCCodeFirst.Models.Entities;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CoreMVCCodeFirst.Models.Configurations
{
    public abstract class BaseConfigurations<T> : IEntityTypeConfiguration<T> where T : BaseEntitiy
    {
        public virtual void Configure(EntityTypeBuilder<T> builder)
        {
            builder.Property(x => x.CreatedDate).HasColumnName("Yaratılma Tarihi");
        }
    }
}
