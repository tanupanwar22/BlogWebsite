using Blog.Model;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Blog.Controllers
{
	public class HomeController : Controller
	{
        private readonly BlogDbContext _dbContext;
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger, BlogDbContext dbContext)
        {
            _logger = logger;
            _dbContext = dbContext;
        }

        User userdetails = new User();

        public ActionResult Index()
        {
            return View();
        }
        [HttpGet]
        public ActionResult Register()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Register(User model)
        {
            User obj = new User();
            if (_dbContext.Users.Any(x => x.UserName == model.UserName))
            {
                ViewBag.Notification = "This UserName has already existed";
            }
            else
            {

                obj.UserId = Guid.NewGuid();
                obj.FullName = model.FullName;
                obj.Email = model.Email;
                obj.UserName = model.UserName;
                obj.Password = model.Password;
                obj.JoinedOn = DateTime.Now;
                obj.IsAuthor = model.IsAuthor;
                _dbContext.Users.Add(obj);
                _dbContext.SaveChanges();
                //_dbContext.UserDatas.Add(model).ToString();

                return RedirectToAction("Login");
            }
            return View();

        }

      
        [HttpGet]
        public ActionResult Login()
        {
            //var row = _dbContext.UserDatas.Where(x => x.UserId == id).FirstOrDefault();
            return View();
        }
        [HttpPost]
        public ActionResult Login(User ua)
        {

            userdetails = _dbContext.Users.Where(m => m.UserName == ua.UserName && m.Password == ua.Password).FirstOrDefault();
            if (userdetails != null)
            {

               // return RedirectToAction("Welcome");
                return RedirectToAction("BlogIndex");

            }
            else
            {
                ViewBag.Notification = "InvalidUser UserName and Password !! ";


            }
            return View();



        }
        public ActionResult BlogIndex()
        {

            return View();
        }

        [HttpGet]
        public ActionResult Feed()
        {

           List<Post> existingEntry = _dbContext.posts.OrderByDescending(s => s.Creation_Date).ToList();

            return View(model: existingEntry);

        }
       
        [HttpGet]
        public IActionResult CreatorPage(Guid id)
        {
            if (id != Guid.Empty)
            {
                Post existingEntry = _dbContext.posts.Where(s => s.PostId == id).FirstOrDefault(); 

                return View(model: existingEntry);
            }

            return View();
        }

        [HttpPost]
        public IActionResult CreatorPage(Post entry)
        {
            Post existingEntry = _dbContext.posts.Where(s => s.PostId == entry.PostId).FirstOrDefault();
            if(existingEntry!=null)
			{
                existingEntry.Content = entry.Content;
                existingEntry.Update_Date = DateTime.Now;
                _dbContext.posts.Update(existingEntry);
                _dbContext.SaveChanges();
            }
            else
            {
                // New article
                Post newEntry = new Post();
                newEntry.Content = entry.Content;
                newEntry.PostId = Guid.NewGuid();
                newEntry.Status = "Published";
                newEntry.Title = entry.Title;
                newEntry.AuthorId = userdetails.UserId.ToString();
                newEntry.AuthorName = userdetails.FullName;
                newEntry.Published_Date = DateTime.Now;
                newEntry.Creation_Date = DateTime.Now;
                newEntry.Update_Date = DateTime.Now;


                _dbContext.Add(newEntry);
                _dbContext.SaveChanges();
            }
          
            return RedirectToAction("Feed");
        }
        //public ActionResult Edit(Post entry)
        //{
        //    Post existingEntry = _dbContext.posts.Where(s => s.PostId == entry.PostId).FirstOrDefault();
        //    if (existingEntry != null)
        //    {
        //        existingEntry.Content = entry.Content;
        //        existingEntry.Update_Date = DateTime.Now;
        //        _dbContext.posts.Update(existingEntry);
        //        _dbContext.SaveChanges();
        //    }
        //    //var row = _dbContext.UserDatas.Where(x => x.UserId == id).FirstOrDefault();
        //    return View();
        //}
    }
}
