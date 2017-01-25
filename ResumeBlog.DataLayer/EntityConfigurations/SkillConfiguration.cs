using ResumeBlog.Model.ResumeModelClasses;
using System.Data.Entity.ModelConfiguration;

namespace ResumeBlog.DataLayer.EntityConfigurations
{
    internal class SkillConfiguration : EntityTypeConfiguration<Skill>
    {
        public SkillConfiguration()
        {
            Property(s => s.Title).IsRequired()
                .HasMaxLength(128);

            Property(s => s.Level).IsRequired();

            Ignore(s => s.IsDirty);

        }
    }
}