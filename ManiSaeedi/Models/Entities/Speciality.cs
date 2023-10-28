using System.ComponentModel.DataAnnotations;
using System.Reflection.Metadata.Ecma335;
using System.Security.Permissions;

namespace ManiSaeedi.Models.Entities
{
    public class Speciality
    {
        public Speciality()
        {
            
        }

        [Key]
        public int Id { get; set; }
        public string Field { get; set; }
        public string Grade { get; set; }
        public int GradeNumber { get; set; }
        public bool IsActive { get; set; }
    }
}
