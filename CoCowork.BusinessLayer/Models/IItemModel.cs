using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoCowork.BusinessLayer.Models
{
    public interface IItemModel
    {
        public int Id { get; set; }
        public int Number { get; set; }
        public string Name { get; set; }
        public bool IsActive { get; set; }
    }
}
