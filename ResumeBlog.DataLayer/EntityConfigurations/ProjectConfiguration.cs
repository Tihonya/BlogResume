using ResumeBlog.Model.ResumeModelClasses;
using System.Data.Entity.ModelConfiguration;

namespace ResumeBlog.DataLayer.EntityConfigurations
{
    internal class ProjectConfiguration : EntityTypeConfiguration<Project>
    {
        public ProjectConfiguration()
        {
            Property(p => p.Title).IsRequired()
                .HasMaxLength(256);

            Property(p => p.Description).IsRequired()
                .HasMaxLength(1024);

            Property(p => p.GitHub).HasMaxLength(256);
            Property(p => p.DemoUrl).HasMaxLength(256);

            Ignore(p => p.IsDirty);

        }
    }
}