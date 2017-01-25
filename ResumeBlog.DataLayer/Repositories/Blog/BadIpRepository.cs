using ResumeBlog.Model.IRepositories;
using ResumeBlog.Model.IRepositories.IBlogRepo;

namespace ResumeBlog.DataLayer.Repositories.Blog
{
    public class BadIpRepository : IBadIpRepository
    {
        private readonly ResumeBlogDbContext _context;

        public BadIpRepository(ResumeBlogDbContext context)
        {
            _context = context;
        }

        public void RealizationIsAbsent(){ }
    }
}
