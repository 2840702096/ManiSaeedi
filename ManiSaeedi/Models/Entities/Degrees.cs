using System.ComponentModel.DataAnnotations;
using System.ComponentModel.Design.Serialization;
using System.Security.Principal;

namespace ManiSaeedi.Models.Entities
{
    public class Degrees
    {
        public Degrees()
        {
            
        }

        [Key]
        public int Id { get; set; }
        public string Title { get; set; }
        public string Image { get; set; }
        public bool IsActive { get; set; }
    }
}
