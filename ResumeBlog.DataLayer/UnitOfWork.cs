using ResumeBlog.DataLayer.Repositories;
using ResumeBlog.DataLayer.Repositories.Blog;
using ResumeBlog.DataLayer.Repositories.Resume;
using ResumeBlog.Model.IRepositories;
using ResumeBlog.Model.IRepositories.IBlogRepo;
using ResumeBlog.Model.IRepositories.IResumeRepo;
using ResumeBlog.Model.IRepositories.IUnitOfWork;

namespace ResumeBlog.DataLayer
{
    public  class UnitOfWork : IUnitOfWork
    {
        private readonly ResumeBlogDbContext _context;

        public IBadIpRepository BadIps { get; }
        public ICategoryRepository Categories { get; }
        public ICommentRepository Comments { get; }
        public ICompanyRepository Companies { get; }
        public IDeveloperProfileRepository DeveloperProfiles { get; }
        public IEducationRepository Educations { get; }
        public IKeyPointRepository KeyPoints { get; }
        public IPostRepository Posts { get; }
        public IPostTagRepository PostTags { get; }
        public IProjectRepository Projects { get; }
        public ISkillRepository Skills { get; }
        public IUnauthorizedUserRepository UnauthorizedUsers { get; }
        public IUserIdentityRepository IdentityUsers { get; }
        public IWorkExperienceRepository WorkExperiences { get; }


        public UnitOfWork(ResumeBlogDbContext context)
        {
            _context = context;
            BadIps=new BadIpRepository(context);
            Categories = new CategoryRepository(context);
            Comments = new CommentRepository(context);
            Companies= new CompanyRepository(context);
            DeveloperProfiles= new DeveloperProfileRepository(context);
            Educations = new EducationRepository(context);
            KeyPoints=new KeyPointRepository(context);
            Posts = new PostRepository(context);
            PostTags = new PostTagRepository(context);
            Projects = new ProjectRepository(context);
            Skills = new SkillRepository(context);
            UnauthorizedUsers= new UnauthorizedUserRepository(context);
            IdentityUsers = new UserIdentityRepository(context);
            WorkExperiences = new WorkExperienceRepository(context);
        }

        public void Complete()
        {
            _context.SaveChanges();
        }

        public void CompleteAsync()
        {
            _context.SaveChangesAsync();
        }
    }
}
