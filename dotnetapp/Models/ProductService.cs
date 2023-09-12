using dotnetapp.Models;
using System.Linq;

namespace dotnetapp.Models
{
    public interface IProductService
    {
        public IQueryable<Product> GetProductList();
        public bool AddProduct(Product product);
        public bool DeleteProduct(int Id);
    }
    //Fill ur code
    public class ProductService : IProductService
    {
       private readonly ProductDBContext _dbContext;

        public ProductService(ProductDBContext dbContext)
        {
            _dbContext = dbContext;
        }
        public IQueryable<Product> GetProductList()
        {
            var query = _dbContext<product>();
           return query;
        }
        public bool AddProduct(Product product)
        {
            Product product = new product
            return false;
        }

        public bool DeleteProduct(int Id)
        {
            return false;
        }
    }
}