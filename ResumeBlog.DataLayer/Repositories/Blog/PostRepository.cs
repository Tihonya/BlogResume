using ResumeBlog.Model.IRepositories.IBlogRepo;

namespace ResumeBlog.DataLayer.Repositories.Blog
{
    public class PostRepository : IPostRepository
    {
        private readonly ResumeBlogDbContext _context;

        public PostRepository(ResumeBlogDbContext context)
        {
            _context = context;
        }

        public void RealizationIsAbsent()
        {
        }
    }
}
