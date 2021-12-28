using System;

namespace CoCowork.BusinessLayer.Models
{
    public class ClientModel
    {
        public string Phone { get; set; }
        public string Email { get; set; }
        public DateTime BirthDate { get; set; }
        public int PaperAmount { get; set; }
        public DateTime PaperEndDate { get; set; }
        public string FullName
        {
            get
            {
                return FirstName + " " + LastName;
            }
        }



    }
}
