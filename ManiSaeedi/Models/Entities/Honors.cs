using System.ComponentModel.DataAnnotations;

namespace ManiSaeedi.Models.Entities
{
    public class Honors
    {
        public Honors()
        {

        }

        [Key]
        public int Id { get; set; }
        public string Title { get; set; }
        public string Image { get; set; }
        public bool IsActive { get; set; }
    }
}
