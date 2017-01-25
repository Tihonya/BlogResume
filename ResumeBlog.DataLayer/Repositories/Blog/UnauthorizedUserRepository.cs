using ResumeBlog.Model.IRepositories.IBlogRepo;

namespace ResumeBlog.DataLayer.Repositories.Blog
{
    public class UnauthorizedUserRepository : IUnauthorizedUserRepository
    {
        private readonly ResumeBlogDbContext _context;

        public UnauthorizedUserRepository(ResumeBlogDbContext context)
        {
            _context = context;
        }

        public void RealizationIsAbsent()
        {
        }
    }
}
