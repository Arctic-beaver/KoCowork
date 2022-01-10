using System;

namespace CoCowork.BusinessLayer.Models
{
    public class ClientModel : ClientShortModel
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
        public DateTime? DateBirth { get; set; }
        public int? PaperAmount { get; set; }
        public DateTime? PaperEndDate { get; set; }
    }
}
