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
            var query = _dbContext.Products.ToList();
           return query;
        }
        public bool AddProduct(Product product)
        {
            Products.add(product);
            _dbContext.SaveChanges();
            return true;
        }

        public bool DeleteProduct(int Id)
        {
            var deleteProduct = Products.Find(id==Id);
            Products.Remove(deleteProduct);
            return true;
        }
    }
}