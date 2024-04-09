namespace LegoSolution1_10.Models;

    public class EFLegoRepository : ILegoRepository
    {
        private LegoDatabaseContext _context;
        
        public EFLegoRepository(LegoDatabaseContext temp)
        {
            _context = temp;
        }

        public IQueryable<Product> Products => _context.Products;
    }
