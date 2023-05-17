using Assignment_Chsarp5_datntph19899._1_DataProcessing._1_Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Assignment_Chsarp5_datntph19899._1_DataProcessing._2_Configurations
{
    public class ReviewsConfiguration : IEntityTypeConfiguration<Reviews>
    {
        public void Configure(EntityTypeBuilder<Reviews> builder)
        {
            builder.HasKey(c => c.ID);
        }
    }
}
