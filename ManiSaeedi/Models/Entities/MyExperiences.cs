using System.ComponentModel.DataAnnotations;

namespace ManiSaeedi.Models.Entities
{
    public class MyExperiences
    {
        public MyExperiences()
        {
            
        }

        [Key]
        public int Id { get; set; }
        public string Text { get; set; }
        public bool IsActive { get; set; }
    }
}
