using BlogCeyinSite.Models;
using System.Linq;
using System.Web.Mvc;

namespace BlogCeyinSite.Controllers
{
    public class HomeController : Controller
    {
        private BlogContext context = new BlogContext();
        // GET: Home
        public ActionResult Index()
        {

            var blogs = context.Database.SqlQuery<BlogModel>("getConfirmedAndPublished");
            /*
            var blogs = context.Blogs
                .Select(i=> new BlogModel() { 
                    Id = i.Id,
                    Title = i.Title,
                    Description = i.Description,
                    Image = i.Image,
                    SubmitTime = i.SubmitTime,
                    Confirm = i.Confirm,
                    PublishHome = i.PublishHome,
                    Author = i.Author
                })
                .Where(i => i.Confirm == true && i.PublishHome == true).OrderByDescending(i => i.SubmitTime);
            */
            // blog datalarını initialize etmesi için başta veritababnını komple silince stored procedure de gidiyo 
            // ilk sefer kullanımda hata vermemesi amaçlı bu kodu yoruma aldım.
             

            return View(blogs.ToList());
        }
    }
}