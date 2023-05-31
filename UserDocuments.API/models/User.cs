using Microsoft.Extensions.Hosting;

namespace UserDocuments.API.models
{
    public class User
    {
        public int Id { get; set; }
        public int Ying { get; set; }//ИИН
        public string Login { get; set; }
        public string Password { get; set; }
        public string Name { get; set; }
        public DateTime RegisterDate { get; set; }
        public ICollection<Document> Documents { get; }
    }
}
