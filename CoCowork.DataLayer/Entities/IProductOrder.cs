namespace CoCowork.DataLayer.Entities
{
    public interface IProductOrder
    {
        int Amount { get; set; }
        Product Product { get; set; }
    }
}