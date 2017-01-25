using ResumeBlog.Model.IRepositories.IResumeRepo;

namespace ResumeBlog.DataLayer.Repositories.Resume
{
    public class ProjectRepository : IProjectRepository
    {
        private readonly ResumeBlogDbContext _context;

        public ProjectRepository(ResumeBlogDbContext context)
        {
            _context = context;
        }

        public void RealizationIsAbsent()
        {
        }
    }
}
