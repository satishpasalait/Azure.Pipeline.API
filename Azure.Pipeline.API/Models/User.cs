namespace Azure.Pipeline.API.Models
{
    public class User
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string ADName { get; set; }
        public string Department { get; set; }
        public string Role { get; set; }
        public string Status { get; set; }
        public DateTime CreatedOn { get; set; }
    }
}
