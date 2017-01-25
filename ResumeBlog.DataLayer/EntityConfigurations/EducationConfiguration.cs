using ResumeBlog.Model.ResumeModelClasses;
using System.Data.Entity.ModelConfiguration;

namespace ResumeBlog.DataLayer.EntityConfigurations
{
    internal class EducationConfiguration : EntityTypeConfiguration<Education>
    {
        public EducationConfiguration()
        {
            Property(e => e.School).IsRequired()
                .HasMaxLength(512);

            Property(e => e.Specialization).IsRequired()
                .HasMaxLength(256);

            HasMany(e=>e.KeyPoints)
                .WithRequired()
                .WillCascadeOnDelete(true);

        }
    }
}