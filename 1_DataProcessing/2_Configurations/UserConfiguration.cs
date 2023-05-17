using Assignment_Chsarp5_datntph19899._1_DataProcessing._1_Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Assignment_Chsarp5_datntph19899._1_DataProcessing._2_Configurations
{
    public class UserConfiguration : IEntityTypeConfiguration<Users>
    {
        public void Configure(EntityTypeBuilder<Users> builder)
        {
            builder.HasKey(c => c.ID);
            builder.Property(c => c.User).HasMaxLength(128).IsRequired();
            builder.Property(c => c.Password).HasMaxLength(128).IsRequired();
            builder.Property(c => c.Name).HasMaxLength(128).IsRequired();
            builder.Property(c => c.Description).HasMaxLength(526).IsRequired();
            builder.Property(c => c.Email).HasMaxLength(128).IsRequired();
            builder.Property(c => c.PhoneNumber).HasMaxLength(10).IsRequired();
            builder.Property(c=>c.Status).IsRequired();

            builder.HasMany(c => c.Bills).WithOne(c => c.Users).HasForeignKey(c => c.UserID);
            builder.HasMany(c => c.Orders).WithOne(c => c.Users).HasForeignKey(c => c.UserID);
            builder.HasOne(c => c.Role).WithMany(c => c.Users).HasForeignKey(c => c.IDRole);
        }
    }
}
