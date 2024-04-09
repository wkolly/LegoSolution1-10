using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using LegoSolution1_10.Models;

namespace LegoSolution1_10.Controllers;

public class HomeController : Controller
{
    
    private readonly LegoDatabaseContext _context;

    public HomeController(LegoDatabaseContext context)
    {
        _context = context;
    }

    public IActionResult Index()
    {
        IQueryable<Product> products = _context.Products; // Adjust this line based on how you access your products
        return View(products);
        
    }

    public IActionResult Privacy()
    {
        return View();
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}
