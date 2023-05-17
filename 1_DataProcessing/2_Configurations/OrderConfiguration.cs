using Assignment_Chsarp5_datntph19899._1_DataProcessing._1_Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Assignment_Chsarp5_datntph19899._1_DataProcessing._2_Configurations
{
    public class OrderConfiguration : IEntityTypeConfiguration<Order>
    {
        public void Configure(EntityTypeBuilder<Order> builder)
        {
            builder.HasKey(c => c.OrdelID);
            builder.Property(c => c.OrderDate).IsRequired();
            builder.Property(c=>c.TotalPrice).IsRequired();
            builder.Property(c=>c.Status).IsRequired();

            builder.HasMany(c=>c.OrderDetail).WithOne(c => c.Order).HasForeignKey(c => c.OrderID);
        }
    }
}
