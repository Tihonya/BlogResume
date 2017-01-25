using ResumeBlog.Model.BlogModelClasses;
using System.Data.Entity.ModelConfiguration;

namespace ResumeBlog.DataLayer.EntityConfigurations
{
    internal class CategoryConfiguration : EntityTypeConfiguration<Category>
    {
        public CategoryConfiguration()
        {
            Property(c => c.Url).HasMaxLength(64);
            Property(c => c.Title).IsRequired()
                .HasMaxLength(80);

            HasMany(c => c.Posts)
                .WithRequired(p=>p.Category)
                .HasForeignKey(p=>p.CategoryId)
                .WillCascadeOnDelete(false);

        }
    }
}