namespace CoCowork.DataLayer.Entities
{
    public class Product
    {
        public int Id { get; }
        public string Name { get; set; }
        public int Amount { get; set; }
        public int PriceForOne { get; set; }
        public string Description { get; set; }
    }
}
