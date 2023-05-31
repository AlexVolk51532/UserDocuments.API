using Microsoft.Identity.Client;

namespace UserDocuments.API.models
{
    public class EditHistory
    {
        public int Id { get; set; }
        public string Edit { get; set; }//Изменения
        public DateTime EditDate { get; set; }
        public string DataBefore { get; set; }//Что было до изменения
        public User User { get; set; }
        public Document Document { get; set; }
    }
}
