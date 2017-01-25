using ResumeBlog.Model.BlogModelClasses;
using System.Data.Entity.ModelConfiguration;

namespace ResumeBlog.DataLayer.EntityConfigurations
{
    internal class UnauthorizedUserConfiguration : EntityTypeConfiguration<UnauthorizedUser>
    {
        public UnauthorizedUserConfiguration()
        {
            Property(uu => uu.Name).IsRequired()
                .HasMaxLength(20);

            Property(uu => uu.Ip).HasMaxLength(16);

            HasMany(uu=>uu.Comments).WithOptional(c=>c.UnauthorizedUser)
                .HasForeignKey(c=>c.UnauthorizedUserId)
                .WillCascadeOnDelete(false);


        }
    }
}