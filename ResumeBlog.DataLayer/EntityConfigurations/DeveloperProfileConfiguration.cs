using ResumeBlog.Model.ResumeModelClasses;
using System.Data.Entity.ModelConfiguration;

namespace ResumeBlog.DataLayer.EntityConfigurations
{
    internal class DeveloperProfileConfiguration : EntityTypeConfiguration<DeveloperProfile>
    {
        public DeveloperProfileConfiguration()
        {
            HasKey(dp => dp.UserId);

            Property(dp => dp.ContactPhone)
                .HasMaxLength(20);

            Property(dp => dp.Email)
                .HasMaxLength(64);

            Property(dp => dp.SelfIntroduce)
                .HasMaxLength(1024).IsRequired();

            Property(dp => dp.Position)
                .IsRequired()
                .HasMaxLength(160);

            Property(dp => dp.GitHubUrl)
                .HasMaxLength(256);
            Property(dp => dp.BlogUrl)
                .HasMaxLength(256);
            Property(dp => dp.LinkedInUrl)
                .HasMaxLength(256);

            Property(dp => dp.AdditionalInformation)
                .HasMaxLength(1024);

            HasMany(dp=>dp.Skills).WithRequired()
                .WillCascadeOnDelete(true);

            HasMany(dp=>dp.Projects).WithRequired()
                .HasForeignKey(p => p.DeveloperId)
                .WillCascadeOnDelete(true);

            HasMany(dp=>dp.Educations).WithRequired()
                .WillCascadeOnDelete(true);

            HasMany(dp=>dp.WorkExperiences)
                .WithRequired()
                .WillCascadeOnDelete(true);

            Ignore(dp => dp.IsDirty);

        }
    }
}