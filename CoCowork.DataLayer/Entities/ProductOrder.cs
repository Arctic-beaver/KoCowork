namespace CoCowork.DataLayer.Entities
{
    public class ProductOrder : BaseOrder, IProductOrder
    {
        public Product Product { get; set; }
        public int Amount { get; set; }
    }
}
