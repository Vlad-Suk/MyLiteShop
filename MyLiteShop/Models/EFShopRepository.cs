namespace MyLiteShop.Models
{
    public class EFShopRepository : IShopRepository
    {
        private ShopDbContext _context;
        public EFShopRepository(ShopDbContext ctx)
        {
            _context = ctx;
        }
        public IQueryable<Product> Products => _context.Products;
    }
}
