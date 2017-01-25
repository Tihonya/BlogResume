using ResumeBlog.Model.IRepositories;

namespace ResumeBlog.DataLayer.Repositories
{
    public class UserIdentityRepository : IUserIdentityRepository   
    {
        private readonly ResumeBlogDbContext _context;

        public UserIdentityRepository(ResumeBlogDbContext context)
        {
            _context = context;
        }

        public void RealizationIsAbsent()
        {
        }
    }
}
