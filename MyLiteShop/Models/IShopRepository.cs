namespace MyLiteShop.Models
{
    public interface IShopRepository
    {
        IQueryable<Product> Products { get; }
    }
}
