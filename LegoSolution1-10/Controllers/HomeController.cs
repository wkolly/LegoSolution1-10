using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using LegoSolution1_10.Models;

namespace LegoSolution1_10.Controllers;

public class HomeController : Controller
{
    
    private readonly ILegoRepository _repo;
        
    public HomeController(ILegoRepository temp)
    {
        _repo = temp;
    }

    public IActionResult Index()
    {
        var productData = _repo.Products
            .OrderBy(x => x.Name)
            .Take(6);
        return View(productData);
        
    }

    public IActionResult Privacy()
    {
        return View();
    }

    public IActionResult AboutUs()
    {
        return View();
    }

    // public IActionResult Products()
    // {
    //     var productData = _repo.Products;
    //     return View(productData);
    // }
    
    public IActionResult Products()
    {
        var productData = _repo.Products.OrderBy(p => p.Name);
        return View("Products", productData); // The view name "Products" is specified here
    }


    public IActionResult ProductDetails(string id)
    {
        var product = _repo.Products.FirstOrDefault(p => p.ProductId == id);
        if (product == null)
        {
            return NotFound(); // If no product is found, return the NotFound view
        }
        return View("ProductDetails", product); // The view name "ProductDetails" is specified here
    }


    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}
