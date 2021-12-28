namespace CoCowork.DataLayer.Entities
{
    public class Room
    {
        public int Id { get;  }
        public string Type { get; set; }
        public int AmountOfPeople { get; set; }
        public decimal PricePerHour { get; set; }
        public string Description { get; set; }
    }
}
