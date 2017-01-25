using ResumeBlog.Model;
using System.Data.Entity.ModelConfiguration;

namespace ResumeBlog.DataLayer.EntityConfigurations
{
    internal class UserIdentityConfiguration : EntityTypeConfiguration<UserIdentity>
    {
        public UserIdentityConfiguration()
        {
            Property(ui => ui.FirstName).IsRequired()
                .HasMaxLength(22);

            Property(ui => ui.MiddleName)
                .HasMaxLength(25);

            Property(ui => ui.LastName)
                .HasMaxLength(25);

            Property(ui => ui.PhotoUrl)
                .HasMaxLength(256);

            Property(ui => ui.PhoneMobile)
                .HasMaxLength(20);

            Property(ui => ui.AboutMe)
                .HasMaxLength(512);

            Property(ui => ui.Ip).HasMaxLength(16);

            HasOptional(ui=>ui.DeveloperProfile)
                .WithRequired(dp=>dp.Developer)
                .WillCascadeOnDelete(true);

            HasOptional(ui=>ui.Company)
                .WithRequired(c=>c.User)
                .WillCascadeOnDelete(true);

            HasMany(ui=>ui.Posts)
                .WithRequired(p=>p.Author)
                .HasForeignKey(p=>p.AuthorId)
                .WillCascadeOnDelete(false);

            HasMany(ui=>ui.Comments)
                .WithOptional(c=>c.Author)
                .HasForeignKey(c=>c.AuthorId)
                .WillCascadeOnDelete(false);

        }
    }
}