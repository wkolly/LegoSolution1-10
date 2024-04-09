namespace LegoSolution1_10.Models;

    public interface ILegoRepository
    {
        public IQueryable<Product> Products { get; }
    }
    

