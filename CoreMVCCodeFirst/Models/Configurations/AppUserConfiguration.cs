using CoreMVCCodeFirst.Models.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CoreMVCCodeFirst.Models.Configurations
{
    public class AppUserConfiguration:BaseConfigurations<AppUser>
    {
        public override void Configure(EntityTypeBuilder<AppUser> builder)
        {
            base.Configure(builder);
            builder.ToTable("Kullanıcılar");
            builder.HasOne(x => x.Profiles).WithOne(x=>x.AppUser).HasForeignKey<AppUserProfile>(x=>x.Id);
        }
    }
}
