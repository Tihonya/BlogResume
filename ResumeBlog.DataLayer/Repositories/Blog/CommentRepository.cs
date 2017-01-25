using ResumeBlog.Model.IRepositories.IBlogRepo;

namespace ResumeBlog.DataLayer.Repositories.Blog
{
    public class CommentRepository : ICommentRepository
    {
        private readonly ResumeBlogDbContext _context;

        public CommentRepository(ResumeBlogDbContext context)
        {
            _context = context;
        }

        public void RealizationIsAbsent()
        {
        }
    }
}
