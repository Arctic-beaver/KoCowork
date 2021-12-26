namespace CoCowork.BusinessLayer.Models
{
    public interface IItemModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }
    }
}
