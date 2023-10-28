namespace ManiSaeedi.Models.Entities
{
    public class ContactMe
    {
        public ContactMe()
        {
            
        }

        public int Id { get; set; }
        public string FullName { get; set; }
        public string Email { get; set; }
        public string Subject { get; set; }
        public string Body { get; set; }
        public bool IsActive { get; set; }
    }
}
