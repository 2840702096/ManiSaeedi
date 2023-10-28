using System.ComponentModel.DataAnnotations;

namespace ManiSaeedi.Models.Entities
{
    public class HonorVideos
    {
        public HonorVideos()
        {
            
        }

        [Key]
        public int Id { get; set; }
        public string Title { get; set; }
        public string Video { get; set; }
        public bool IsActive { get; set; }
    }
}
