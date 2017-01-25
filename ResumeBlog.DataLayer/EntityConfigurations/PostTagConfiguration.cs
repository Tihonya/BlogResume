using ResumeBlog.Model.BlogModelClasses;
using System.Data.Entity.ModelConfiguration;

namespace ResumeBlog.DataLayer.EntityConfigurations
{
    internal class PostTagConfiguration : EntityTypeConfiguration<PostTag>
    {
        public PostTagConfiguration()
        {
            Property(pt => pt.Tag).IsRequired()
                .HasMaxLength(48);

        }
    }
}