using Microsoft.AspNet.Identity.EntityFramework;
using ResumeBlog.DataLayer.EntityConfigurations;
using ResumeBlog.Model;
using ResumeBlog.Model.BlogModelClasses;
using ResumeBlog.Model.Interfaces;
using ResumeBlog.Model.ResumeModelClasses;
using System;
using System.Data.Entity;
using System.Linq;
using System.Threading.Tasks;

namespace ResumeBlog.DataLayer
{
    public class ResumeBlogDbContext  : IdentityDbContext<UserIdentity>
    {

        public ResumeBlogDbContext()
            : base("DefaultConnection", throwIfV1Schema: false)
        {


        }

        public DbSet<Category> Categories { get; set; }
        public DbSet<Post> Posts { get; set; }
        public DbSet<PostTag> PostTags { get; set; }
        public DbSet<Comment> Comments { get; set; }
        public DbSet<UnauthorizedUser> UnauthorizedUsers { get; set; }
        public DbSet<BadIp> BadIps { get; set; }

        public DbSet<DeveloperProfile> DeveloperProfiles { get; set; }
        public DbSet<Skill> Skills { get; set; }
        public DbSet<Project> Projects { get; set; }
        public DbSet<Education> Educations { get; set; }
        public DbSet<KeyPoint> KeyPoints { get; set; }
        public DbSet<WorkExperience> WorkExperiences { get; set; }

        public DbSet<Company> Companies { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Configurations.Add(new UserIdentityConfiguration());

            modelBuilder.Configurations.Add(new CategoryConfiguration());
            modelBuilder.Configurations.Add(new PostConfiguration());
            modelBuilder.Configurations.Add(new PostTagConfiguration());
            modelBuilder.Configurations.Add(new CommentConfiguration());
            modelBuilder.Configurations.Add(new UnauthorizedUserConfiguration());
            modelBuilder.Configurations.Add(new BadIpConfiguration());

            modelBuilder.Configurations.Add(new DeveloperProfileConfiguration());
            modelBuilder.Configurations.Add(new SkillConfiguration());
            modelBuilder.Configurations.Add(new ProjectConfiguration());
            modelBuilder.Configurations.Add(new EducationConfiguration());
            modelBuilder.Configurations.Add(new KeyPointConfiguration());
            modelBuilder.Configurations.Add(new WorkExperienceConfiguration());

            modelBuilder.Configurations.Add(new CompanyConfiguration());

            base.OnModelCreating(modelBuilder);
        }

        public override int SaveChanges()
        {
            foreach (var history in this.ChangeTracker.Entries()
                .Where(e => e.Entity is IModificationHistory && (e.State == EntityState.Added ||
                e.State == EntityState.Modified)).Select(e => e.Entity as IModificationHistory))
            {
                history.DateModified = DateTime.Now;
                if (history.DateCreated == DateTime.MinValue)
                {
                    history.DateCreated = DateTime.Now;
                }
            }
            var result =base.SaveChanges();
            foreach (var history in this.ChangeTracker.Entries()
                    .Where(e => e.Entity is IModificationHistory || e.Entity is ICheckChanges )
                    .Select(e => e.Entity as ICheckChanges))
            {
                history.IsDirty = false;
            }
            return result;

        }

        
        public override Task<int> SaveChangesAsync()
        {
            //Async??
            foreach (var history in this.ChangeTracker.Entries()
                .Where(e => e.Entity is IModificationHistory && (e.State == EntityState.Added ||
                e.State == EntityState.Modified)).Select(e => e.Entity as IModificationHistory))
            {
                history.DateModified = DateTime.Now;
                if (history.DateCreated == DateTime.MinValue)
                {
                    history.DateCreated = DateTime.Now;
                }
            }
            var result = base.SaveChangesAsync();
            foreach (var history in this.ChangeTracker.Entries()
                    .Where(e => e.Entity is IModificationHistory || e.Entity is ICheckChanges)
                    .Select(e => e.Entity as ICheckChanges))
            {
                history.IsDirty = false;
            }
            return result;
        }

        public static ResumeBlogDbContext Create()
        {
            return new ResumeBlogDbContext();
        }
    }
}
