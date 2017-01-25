using ResumeBlog.Model.IRepositories.IResumeRepo;

namespace ResumeBlog.DataLayer.Repositories.Resume
{
    public class KeyPointRepository : IKeyPointRepository
    {
        private readonly ResumeBlogDbContext _context;

        public KeyPointRepository(ResumeBlogDbContext context)
        {
            _context = context;
        }

        public void RealizationIsAbsent()
        {
        }
    }
}
