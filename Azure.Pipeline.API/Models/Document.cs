namespace Azure.Pipeline.API.Models
{
    public class Document
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string ClientName { get; set; }
        public string Source { get; set; }
        public string FileName { get; set; }
        public string Status { get; set; }
        public string DocumentCategory { get; set; }
        public DateTime DateCreated { get; set; }
    }
}
