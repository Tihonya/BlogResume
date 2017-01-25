using ResumeBlog.Model.IRepositories.IBlogRepo;

namespace ResumeBlog.DataLayer.Repositories.Blog
{
    public class PostTagRepository : IPostTagRepository
    {
        private readonly ResumeBlogDbContext _context;

        public PostTagRepository(ResumeBlogDbContext context)
        {
            _context = context;
        }

        public void RealizationIsAbsent()
        {
        }
    }
}
