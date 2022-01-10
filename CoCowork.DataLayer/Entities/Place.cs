namespace CoCowork.DataLayer.Entities
{
    public class Place
    {
        public int Id { get; set; }
        public int Number { get; set; }
        public int? MiniOfficeId { get; set; }
        public decimal PricePerDay { get; set; }
        public decimal PriceFixedPerDay { get; set; }
        public string Description { get; set; }
    }
}
