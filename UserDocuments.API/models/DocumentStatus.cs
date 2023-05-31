namespace UserDocuments.API.models
{
    public class DocumentStatus
    {
        public int Id { get; set; }
        public Document Document { get; set; }
        public string Status { get; set; }
        public User User { get; set; }//Кто создал
        public DateTime CreateDate { get; set; }
    }
}
