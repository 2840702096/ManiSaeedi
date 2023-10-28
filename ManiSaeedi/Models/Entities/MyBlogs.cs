using System.ComponentModel.DataAnnotations;

namespace ManiSaeedi.Models.Entities
{
    public class MyBlogs
    {
        public MyBlogs()
        {
            
        }

        [Key]
        public int Id { get; set; }
        public string Title { get; set; }
        public string Body { get; set; }
        public string Image { get; set; }
        public bool IsActive { get; set; }
    }
}
