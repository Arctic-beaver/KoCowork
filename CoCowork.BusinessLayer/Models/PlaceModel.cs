using CoCowork.DataLayer.Entities;

namespace CoCowork.BusinessLayer.Models
{
    public class PlaceModel : ItemModel
    {
        public int? Number { get; set; }
        public decimal? PricePerDay { get; set; }
        public decimal? PriceFixedPerDay { get; set; }
        public int MiniOfficeId { get; set; }
        public string Description { get; set; }
    }
}