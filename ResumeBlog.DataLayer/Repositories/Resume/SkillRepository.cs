using ResumeBlog.Model.IRepositories.IResumeRepo;

namespace ResumeBlog.DataLayer.Repositories.Resume
{
    public class SkillRepository : ISkillRepository
    {
        private readonly ResumeBlogDbContext _context;

        public SkillRepository(ResumeBlogDbContext context)
        {
            _context = context;
        }

        public void RealizationIsAbsent()
        {
        }
    }
}
