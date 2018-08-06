using VanThuanShop.Data.Infrastructure;
using VanThuanShop.Model.Models;

namespace VanThuanShop.Data.Repositories
{
    public interface IProductRepository
    {
    }

    public class ProductRepository : RepositoryBase<Product>, IProductRepository
    {
        public ProductRepository(IDbFactory dbFactory) : base(dbFactory)
        {
        }
    }
}