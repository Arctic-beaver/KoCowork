using System;

namespace CoCowork.BusinessLayer.Models
{
    public class ClientModel : ClientShortModel
    {
        public string Phone { get; set; }
        public string Email { get; set; }
        public DateTime BirthDate { get; set; }
        public int PaperAmount { get; set; }
        public DateTime PaperEndDate { get; set; }




    }
}
