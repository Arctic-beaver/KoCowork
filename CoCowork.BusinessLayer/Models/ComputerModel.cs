using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoCowork.BusinessLayer.Models
{
    public class ComputerModel : ItemModel
    {
        public string Name { get; set; }
        public int Number { get; set; }
        public decimal PricePerMonth { get; set; }
        public string Description { get; set; }

        public override void Delete()
        {

        }
    }
}
