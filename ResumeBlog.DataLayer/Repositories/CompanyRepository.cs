using ResumeBlog.Model.IRepositories;

namespace ResumeBlog.DataLayer.Repositories
{
    public class CompanyRepository : ICompanyRepository
    {
        private readonly ResumeBlogDbContext _context;

        public CompanyRepository(ResumeBlogDbContext context)
        {
            _context = context;
        }

        public void RealizationIsAbsent()
        {
        }
    }
}
