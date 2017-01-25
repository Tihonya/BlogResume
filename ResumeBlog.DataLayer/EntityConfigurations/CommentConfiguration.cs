using ResumeBlog.Model.BlogModelClasses;
using System.Data.Entity.ModelConfiguration;

namespace ResumeBlog.DataLayer.EntityConfigurations
{
    internal class CommentConfiguration : EntityTypeConfiguration<Comment>
    {
        public CommentConfiguration()
        {
            HasOptional(c=>c.ParentComment)
                .WithMany(c=>c.ChildComments)
                .HasForeignKey(c=>c.ParentId)
                .WillCascadeOnDelete(false);

            Property(c => c.Title).HasMaxLength(128);
            Property(c => c.Content).IsRequired()
                .HasMaxLength(1536);

            //I don't realise now, how I will store Avatar
            Property(c => c.Avatar).HasMaxLength(2048);

            Property(c => c.RelativeLink).HasMaxLength(512);

            Property(c => c.Ip).HasMaxLength(16);

            Property(c => c.ModificationAppliedBy)
                .HasMaxLength(128);            

        }
    }
}