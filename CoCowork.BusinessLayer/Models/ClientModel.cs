using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoCowork.BusinessLayer.Models
{
    public class ClientModel
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
