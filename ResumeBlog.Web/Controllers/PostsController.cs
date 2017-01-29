using ResumeBlog.DataLayer;
using System.Data.Entity;
using System.Linq;
using System.Web.Mvc;

namespace ResumeBlog.Web.Controllers
{
    public class PostsController : Controller
    {
        private readonly ResumeBlogDbContext _context;

        public PostsController()
        {
            _context = new ResumeBlogDbContext();
        }

        [AllowAnonymous]
        // GET: Posts
        public ActionResult MainView()
        {

            var posts = _context.Posts
                .Include(p=>p.Category)
                .Include(p=>p.Tags)
                .ToList();
            return View(posts);
        }
    }
}