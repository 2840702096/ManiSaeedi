using Microsoft.AspNetCore.Http;
using System.ComponentModel.DataAnnotations;

namespace ManiSaeedi.Models.ViewModels
{
    public class AboutMeViewModel
    {
        [Display(Name = "عنوان")]
        [Required(ErrorMessage = "لطفا {0} را وارد کنید")]
        [MaxLength(200, ErrorMessage = "{0} نمی تواند بیشتر از {1} کاراکتر باشد .")]
        public string Title { get; set; }

        [Display(Name = "متن")]
        [Required(ErrorMessage = "لطفا {0} را وارد کنید")]
        public string Body { get; set; }

        public IFormFile Image { get; set; }
        public string CurrentImage { get; set; }
        public int HappyClients { get; set; }
        public int Coffee { get; set; }
        public int CompeletedProjects { get; set; }
        public bool IsActive { get; set; }
    }

    public class SpecialityViewModel
    {
        [Display(Name = "زمینه ی تخصص")]
        [Required(ErrorMessage = "لطفا {0} را وارد کنید")]
        [MaxLength(200, ErrorMessage = "{0} نمی تواند بیشتر از {1} کاراکتر باشد .")]
        public string Field { get; set; }

        [Display(Name = "عنوان درجه")]
        [Required(ErrorMessage = "لطفا {0} را وارد کنید")]
        [MaxLength(200, ErrorMessage = "{0} نمی تواند بیشتر از {1} کاراکتر باشد .")]
        public string Grade { get; set; }
        public int GradeNumber { get; set; }
        public bool IsActive { get; set; }
    }

    public class DegreeViewModel
    {
        [Display(Name = "عنوان")]
        [Required(ErrorMessage = "لطفا {0} را وارد کنید")]
        [MaxLength(200, ErrorMessage = "{0} نمی تواند بیشتر از {1} کاراکتر باشد .")]
        public string Title { get; set; }
        public string CurrentImage { get; set; }
        public IFormFile Image { get; set; }
        public bool IsActive { get; set; }
    }

    public class MyServiceViewModel
    {
        [Display(Name = "عنوان")]
        [Required(ErrorMessage = "لطفا {0} را وارد کنید")]
        [MaxLength(200, ErrorMessage = "{0} نمی تواند بیشتر از {1} کاراکتر باشد .")]
        public string Title { get; set; }
        public bool IsActive { get; set; }
    }

    public class BlogViewModel
    {
        [Display(Name = "عنوان")]
        [Required(ErrorMessage = "لطفا {0} را وارد کنید")]
        [MaxLength(200, ErrorMessage = "{0} نمی تواند بیشتر از {1} کاراکتر باشد .")]
        public string Title { get; set; }

        [Display(Name = "متن")]
        [Required(ErrorMessage = "لطفا {0} را وارد کنید")]
        public string Body { get; set; }
        public string CurrentImage { get; set; }
        public IFormFile Image { get; set; }
        public bool IsActive { get; set; }
    }
}
