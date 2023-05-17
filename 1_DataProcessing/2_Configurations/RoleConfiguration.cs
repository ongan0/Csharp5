using Assignment_Chsarp5_datntph19899._1_DataProcessing._1_Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Assignment_Chsarp5_datntph19899._1_DataProcessing._2_Configurations
{
    public class RoleConfiguration : IEntityTypeConfiguration<Role>
    {
        public void Configure(EntityTypeBuilder<Role> builder)
        {
            builder.HasKey(c => c.ID);
            builder.Property(c => c.Name).HasMaxLength(128).IsRequired();
            builder.Property(c => c.Description).HasMaxLength(526).IsRequired();
            builder.Property(c => c.Status).IsRequired();
        }
    }
}
