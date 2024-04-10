using System.Collections;
namespace LegoSolution1_10.Models.ViewModels;

    public class ProductsListViewModel
    {
        public IQueryable<Product> Products { get; set; }

        public PaginationInfo PaginationInfo { get; set; } = new PaginationInfo();
        public List<int> PageSizeOptions { get; set; }
        
        // Filters
        public string SelectedCategory { get; set; }
        public string SelectedColor { get; set; }

        // Dropdown Lists
        public List<string> Categories { get; set; }
        public List<string> Colors { get; set; }
    }


