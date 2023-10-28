using System.ComponentModel.DataAnnotations;

namespace ManiSaeedi.Models.Entities
{
    public class MyServices
    {
        public MyServices()
        {
            
        }

        [Key]
        public int Id { get; set; }
        public string Title { get; set; }
        public bool IsActive { get; set; }
    }
}
