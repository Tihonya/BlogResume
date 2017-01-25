using ResumeBlog.Model.BlogModelClasses;
using System.Data.Entity.ModelConfiguration;

namespace ResumeBlog.DataLayer.EntityConfigurations
{
    internal class PostConfiguration : EntityTypeConfiguration<Post>
    {
        public PostConfiguration()
        {
            //Url needs to be required, actually.
            Property(p => p.Url).HasMaxLength(256);
            Property(p => p.Title).HasMaxLength(256)
                .IsRequired();

            Property(p => p.Summary).HasMaxLength(1024);
            Property(p => p.Content).HasMaxLength(16384)
                .IsRequired();

            HasMany(p => p.Tags)
                .WithRequired(t => t.Post)
                .HasForeignKey(t => t.PostId)
                .WillCascadeOnDelete(true);

            HasMany(p=>p.Comments)
                .WithRequired(c=>c.RelatedPost)
                .HasForeignKey(c=>c.PostId)
                .WillCascadeOnDelete(true);

            Property(c => c.ModificationAppliedBy)
                .HasMaxLength(128);

            Ignore(c => c.IsDirty);

        }
    }
}