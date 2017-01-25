using ResumeBlog.Model.ResumeModelClasses;
using System.Data.Entity.ModelConfiguration;

namespace ResumeBlog.DataLayer.EntityConfigurations
{
    internal class WorkExperienceConfiguration : EntityTypeConfiguration<WorkExperience>
    {
        public WorkExperienceConfiguration()
        {
            Property(we => we.CompanyName).IsRequired()
                .HasMaxLength(512);

            Property(we => we.Position).IsRequired()
                .HasMaxLength(256);

            Property(we => we.Description)
                .HasMaxLength(1024);

            Ignore(we => we.IsDirty);
        }
    }
}