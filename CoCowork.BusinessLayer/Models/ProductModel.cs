using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoCowork.BusinessLayer.Models
{
    public class ProductModel : iItemModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public const string Type = "Продукты";
    }
}
