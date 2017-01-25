using ResumeBlog.Model.IRepositories.IResumeRepo;

namespace ResumeBlog.DataLayer.Repositories.Resume
{
    public class DeveloperProfileRepository : IDeveloperProfileRepository
    {
        private readonly ResumeBlogDbContext _context;

        public DeveloperProfileRepository(ResumeBlogDbContext context)
        {
            _context = context;
        }

        public void RealizationIsAbsent()
        {
        }
    }
}
