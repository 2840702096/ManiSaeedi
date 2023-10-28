using System.ComponentModel.DataAnnotations;
using System.Reflection.Metadata.Ecma335;

namespace ManiSaeedi.Models.Entities
{
    public class AboutMe
    {
        public AboutMe()
        {
              
        }

        [Key]
        public int Id { get; set; }
        public string Title { get; set; }
        public string Body { get; set; }
        public int HappyClients { get; set; }
        public int Coffees { get; set; }
        public int Completed { get; set; }
        public bool IsActive { get; set; }
    }
}
