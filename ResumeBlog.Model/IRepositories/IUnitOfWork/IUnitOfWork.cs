using ResumeBlog.Model.IRepositories.IBlogRepo;
using ResumeBlog.Model.IRepositories.IResumeRepo;

namespace ResumeBlog.Model.IRepositories.IUnitOfWork
{
    public interface IUnitOfWork
    {
        IBadIpRepository BadIps { get; }
        ICategoryRepository Categories { get; }
        ICommentRepository Comments { get; }
        ICompanyRepository Companies { get; }
        IDeveloperProfileRepository DeveloperProfiles { get; }
        IEducationRepository Educations { get; }
        IKeyPointRepository KeyPoints { get; }
        IPostRepository Posts { get; }
        IPostTagRepository PostTags { get; }
        IProjectRepository Projects { get; }
        ISkillRepository Skills { get; }
        IUnauthorizedUserRepository UnauthorizedUsers { get; }
        IUserIdentityRepository IdentityUsers { get; }
        IWorkExperienceRepository WorkExperiences { get; }
        void Complete();
        void CompleteAsync();

    }
}
