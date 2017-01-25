using System.Data.Entity.ModelConfiguration;
using ResumeBlog.Model.BlogModelClasses;

namespace ResumeBlog.DataLayer.EntityConfigurations
{
    internal class BadIpConfiguration : EntityTypeConfiguration<BadIp>
    {
        public BadIpConfiguration()
        {
            Property(bi => bi.Ip).IsRequired()
                .HasMaxLength(16);
        }
    }
}