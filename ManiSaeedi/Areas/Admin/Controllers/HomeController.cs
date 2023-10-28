using BeautySalon.Models.Tools;
using ImageProcessor.Imaging.Helpers;
using ManiSaeedi.Models.Context;
using ManiSaeedi.Models.Entities;
using ManiSaeedi.Models.ViewModels;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Collections.Specialized;
using System.IO;
using System.Linq;

namespace ManiSaeedi.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class HomeController : Controller
    {
        private readonly ManiContext _context;

        private readonly IWebHostEnvironment _en;
        public HomeController(ManiContext context, IWebHostEnvironment en)
        {
            _context = context;
            _en = en;
        }
        public IActionResult Index()
        {
            return View();
        }

        #region AboutMe

        [Route("AboutMe")]
        public IActionResult AboutMe()
        {
            var A = _context.AboutMe.First();
            AboutMeViewModel Info = _context.AboutMe.Where(a => a.Id == A.Id).Select(a => new AboutMeViewModel
            {
                Title = a.Title,
                HappyClients = a.HappyClients,
                Coffee = a.Coffees,
                CompeletedProjects = a.Completed,
                Body = a.Body,
                IsActive = a.IsActive
            }).Single();

            return View(Info);
        }

        [Route("AboutMe")]
        [HttpPost]
        public IActionResult AboutMe(AboutMeViewModel aboutMe, string currentImage)
        {
            var A = _context.AboutMe.First();
            A.Title = aboutMe.Title;
            A.HappyClients = aboutMe.HappyClients;
            A.Coffees = aboutMe.Coffee;
            A.Completed = aboutMe.CompeletedProjects;
            A.Body = aboutMe.Body;
            A.IsActive = aboutMe.IsActive;

            _context.Update(A);
            _context.SaveChanges();

            return Redirect("/AboutMe");
        }

        #endregion

        #region Speciality

        [Route("Speciality")]
        public IActionResult Speciality()
        {
            var A = _context.Speciality.First();
            SpecialityViewModel Info = _context.Speciality.Where(s => s.Id == A.Id).Select(s => new SpecialityViewModel
            {
                Field = s.Field,
                Grade = s.Grade,
                GradeNumber = s.GradeNumber,
                IsActive = s.IsActive,
            }).Single();

            return View(Info);
        }

        [Route("Speciality")]
        [HttpPost]
        public IActionResult Speciality(SpecialityViewModel speciality)
        {
            var A = _context.Speciality.First();
            A.Field = speciality.Field;
            A.Grade = speciality.Grade;
            A.GradeNumber = speciality.GradeNumber;
            A.IsActive = speciality.IsActive;

            _context.Update(A);
            _context.SaveChanges();

            return Redirect("/Speciality");
        }

        #endregion

        #region Degrees

        [Route("Degrees")]
        public IActionResult Degrees()
        {
            var A = _context.Speciality.First();
            DegreeViewModel Info = _context.Degrees.Where(s => s.Id == A.Id).Select(s => new DegreeViewModel
            {
                Title = s.Title,
                CurrentImage = s.Image,
                IsActive = s.IsActive,
            }).Single();

            ViewBag.WhcichPage = 1;

            return View(Info);
        }

        [Route("Degrees")]
        [HttpPost]
        public IActionResult Degrees(DegreeViewModel degree, string currentImage)
        {
            var A = _context.Degrees.First();
            A.Title = degree.Title;
            A.IsActive = degree.IsActive;

            string ImagePath = "\\Admin\\images\\DegreeImage\\";

            string ThumbPath = "\\Admin\\images\\DegreeThumbnail\\";

            ImageHelper i = new ImageHelper(_en);

            A.Image = i.EditImage(degree.Image, currentImage, ImagePath, ThumbPath);

            _context.Update(A);
            _context.SaveChanges();

            return Redirect("/Degrees");
        }

        #endregion

        #region CommendationLetters

        [Route("CommendationLetters")]
        public IActionResult CommendationLetters()
        {
            var A = _context.CommendationLetters.First();
            DegreeViewModel Info = _context.CommendationLetters.Where(s => s.Id == A.Id).Select(s => new DegreeViewModel
            {
                Title = s.Title,
                CurrentImage = s.Image,
                IsActive = s.IsActive,
            }).Single();

            ViewBag.WhcichPage = 2;

            return View("Degrees", Info);
        }

        [Route("CommendationLetters")]
        [HttpPost]
        public IActionResult CommendationLetters(DegreeViewModel degree, string currentImage)
        {
            var A = _context.CommendationLetters.First();
            A.Title = degree.Title;
            A.IsActive = degree.IsActive;

            string ImagePath = "\\Admin\\images\\CommendationLettersImage\\";

            string ThumbPath = "\\Admin\\images\\CommendationLettersThumbnail\\";

            ImageHelper i = new ImageHelper(_en);

            A.Image = i.EditImage(degree.Image, currentImage, ImagePath, ThumbPath);

            _context.Update(A);
            _context.SaveChanges();

            return Redirect("/CommendationLetters");
        }

        #endregion

        #region Honors

        [Route("Honors")]
        public IActionResult Honors()
        {
            var A = _context.Honors.First();
            DegreeViewModel Info = _context.Honors.Where(s => s.Id == A.Id).Select(s => new DegreeViewModel
            {
                Title = s.Title,
                CurrentImage = s.Image,
                IsActive = s.IsActive
            }).Single();

            ViewBag.WhcichPage = 3;

            return View("Degrees", Info);
        }

        [Route("Honors")]
        [HttpPost]
        public IActionResult Honors(DegreeViewModel degree, string currentImage)
        {
            var A = _context.Honors.First();
            A.Title = degree.Title;
            A.IsActive = degree.IsActive;

            string ImagePath = "\\Admin\\images\\HonorImage\\";

            string ThumbPath = "\\Admin\\images\\HonorThumbnail\\";

            ImageHelper i = new ImageHelper(_en);

            A.Image = i.EditImage(degree.Image, currentImage, ImagePath, ThumbPath);

            _context.Update(A);
            _context.SaveChanges();

            return Redirect("/Honors");
        }

        #endregion

        #region MyServices

        [Route("MyServices")]
        public IActionResult MyServices()
        {
            var A = _context.MyServices.First();
            MyServiceViewModel Info = _context.MyServices.Where(s => s.Id == A.Id).Select(s => new MyServiceViewModel
            {
                Title = s.Title,
                IsActive = s.IsActive
            }).Single();

            return View(Info);
        }

        [Route("MyServices")]
        [HttpPost]
        public IActionResult MyServices(MyServiceViewModel service)
        {
            var A = _context.MyServices.First();
            A.Title = service.Title;
            A.IsActive = service.IsActive;

            _context.Update(A);
            _context.SaveChanges();

            return Redirect("/MyServices");
        }

        #endregion

        #region MyExperiences

        [Route("MyExperiences")]
        public IActionResult MyExperiences()
        {
            var A = _context.MyExperiences.First();
            MyServiceViewModel Info = _context.MyExperiences.Where(s => s.Id == A.Id).Select(s => new MyServiceViewModel
            {
                Title = s.Text,
                IsActive = s.IsActive
            }).Single();

            return View(Info);
        }

        [Route("MyExperiences")]
        [HttpPost]
        public IActionResult MyExperiences(MyServiceViewModel service)
        {
            var A = _context.MyExperiences.First();
            A.Text = service.Title;
            A.IsActive = service.IsActive;

            _context.Update(A);
            _context.SaveChanges();

            return Redirect("/MyExperiences");
        }

        #endregion

        #region MyBlogs

        [Route("MyBlogs")]
        public IActionResult MyBlogs()
        {
            return View(_context.MyBlogs.AsNoTracking().ToList());
        }

        #region CreateWeblog

        [Route("CreateWeblog")]
        public IActionResult CreateWeblog()
        {
            return View();
        }

        [Route("CreateWeblog")]
        [HttpPost]
        public IActionResult CreateWeblog(BlogViewModel blog)
        {
            ManiSaeedi.Models.Entities.MyBlogs Blog = new MyBlogs();

            Blog.Title = blog.Title;
            Blog.IsActive = blog.IsActive;
            Blog.Body = blog.Body;

            string ImagePath = "\\Admin\\images\\WeblogImage\\";

            string ThumbPath = "\\Admin\\images\\WeblogThumbNail\\";

            ImageHelper i = new ImageHelper(_en);

            Blog.Image = i.AddImage(blog.Image, ImagePath, ThumbPath);

            _context.Add(Blog);
            _context.SaveChanges();

            return Redirect("/MyBlogs");
        }

        #endregion

        #region EditWeblog

        [Route("EditWeblog/{Id}")]
        public IActionResult EditWeblog(int id)
        {
            var A = _context.MyBlogs.Find(id);
            BlogViewModel Info = _context.MyBlogs.Where(s => s.Id == A.Id).Select(s => new BlogViewModel
            {
                Title = s.Title,
                Body = s.Body,
                CurrentImage = s.Image,
                IsActive = s.IsActive
            }).Single();

            return View(Info);
        }

        [Route("EditWeblog/{id}")]
        [HttpPost]
        public IActionResult EditWeblog(int id, BlogViewModel blog, string currentImage)
        {
            var Blog = _context.MyBlogs.Find(id);

            Blog.Title = blog.Title;
            Blog.IsActive = blog.IsActive;
            Blog.Body = blog.Body;

            string ImagePath = "\\Admin\\images\\WeblogImage\\";

            string ThumbPath = "\\Admin\\images\\WeblogThumbNail\\";

            ImageHelper i = new ImageHelper(_en);

            Blog.Image = i.EditImage(blog.Image, currentImage, ImagePath, ThumbPath);

            _context.Update(Blog);
            _context.SaveChanges();

            return Redirect("/MyBlogs");
        }

        #endregion

        #region DeleteWeblog

        [Route("DeleteWeblog/{id}")]
        public IActionResult DeleteWeblog(int id, string currentImage)
        {
            var Blog = _context.MyBlogs.Find(id);

            string ImagePath = "\\Admin\\images\\WeblogImage\\";

            string ThumbPath = "\\Admin\\images\\WeblogThumbNail\\";

            string Path = $"{_en.WebRootPath}{ImagePath}{currentImage}";
            FileInfo file = new FileInfo(Path);
            if (file.Exists)
            {
                file.Delete();
            }

            string Path1 = $"{_en.WebRootPath}{ThumbPath}{currentImage}";
            FileInfo file1 = new FileInfo(Path1);
            if (file1.Exists)
            {
                file1.Delete();
            }

            _context.Entry(Blog).State = EntityState.Deleted;
            _context.SaveChanges();

            return Redirect("/MyBlogs");
        }

        #endregion

        #region Body

        [Route("Body")]
        public IActionResult Body(string body)
        {
            ViewBag.Body = body;
            return View();
        }

        #endregion

        #endregion

    }
}