namespace CoCowork.DataLayer.Entities
{
    public class Place
    {
        public int Id { get; set; }
        public MiniOffice MiniOffice { get; set; }
        public decimal PricePerDay { get; set; }
        public decimal PriceFixedPerDay { get; set; }
    }
}
