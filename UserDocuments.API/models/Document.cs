namespace UserDocuments.API.models
{
    public class Document
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public float Weight { get; set; }
        public string Type { get; set; }
        public bool privacy { get; set; }
        public string Way { get; set; }
        public User User { get; set; }
    }
}
