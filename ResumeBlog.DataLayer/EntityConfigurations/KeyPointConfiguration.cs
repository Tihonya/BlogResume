using ResumeBlog.Model.ResumeModelClasses;
using System.Data.Entity.ModelConfiguration;

namespace ResumeBlog.DataLayer.EntityConfigurations
{
    internal class KeyPointConfiguration : EntityTypeConfiguration<KeyPoint>
    {
        public KeyPointConfiguration()
        {
            Property(kp => kp.About).IsRequired()
                .HasMaxLength(256);
        }
    }
}