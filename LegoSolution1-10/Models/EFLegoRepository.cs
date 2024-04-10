using Microsoft.EntityFrameworkCore;

namespace LegoSolution1_10.Models;

    public class EFLegoRepository : ILegoRepository
    {
        private LegoDatabaseContext _context;
        
        public EFLegoRepository(LegoDatabaseContext temp)
        {
            _context = temp;
        }

        public IQueryable<Product> Products => _context.Products;
        
        public IEnumerable<Product> GetAllProducts()
        {
            return _context.Products.ToList();
        }

        public Product GetProductById(string productId)
        {
            return _context.Products.FirstOrDefault(p => p.ProductId == productId);
        }

        public void AddProduct(Product product)
        {
            _context.Products.Add(product);
            _context.SaveChanges();
        }

        public void UpdateProduct(Product product)
        {
            _context.Entry(product).State = EntityState.Modified;
            _context.SaveChanges();
        }

        public void DeleteProduct(string productId)
        {
            var product = _context.Products.FirstOrDefault(p => p.ProductId == productId);
            if (product != null)
            {
                _context.Products.Remove(product);
                _context.SaveChanges();
            }
        }
    }
