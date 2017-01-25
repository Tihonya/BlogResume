using ResumeBlog.Model.IRepositories.IResumeRepo;

namespace ResumeBlog.DataLayer.Repositories.Resume
{
    public class WorkExperienceRepository : IWorkExperienceRepository
    {
        private readonly ResumeBlogDbContext _context;

        public WorkExperienceRepository(ResumeBlogDbContext context)
        {
            _context = context;
        }

        public void RealizationIsAbsent()
        {
        }
    }
}
