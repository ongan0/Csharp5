using Assignment_Chsarp5_datntph19899._1_DataProcessing._1_Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Assignment_Chsarp5_datntph19899._1_DataProcessing._2_Configurations
{
    public class FoodConfiguration : IEntityTypeConfiguration<Food>
    {
        public void Configure(EntityTypeBuilder<Food> builder)
        {
            builder.HasKey(c => c.ID);
            builder.Property(c=>c.FoodName).HasMaxLength(128).IsRequired();
            builder.Property(c=>c.Price).IsRequired();
            builder.Property(c=>c.Description).HasMaxLength(526).IsRequired();

            builder.HasOne(c=>c.Category).WithMany(c=>c.Food).HasForeignKey(c=>c.ID); 
            builder.HasMany(c=>c.BillDetails).WithOne(c=>c.Food).HasForeignKey(c=>c.ID);
        }
    }
}
