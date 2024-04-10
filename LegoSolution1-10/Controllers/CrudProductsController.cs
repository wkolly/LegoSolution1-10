using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;
using LegoSolution1_10.Models;
using LegoSolution1_10.Data;

namespace LegoSolution1_10.Controllers
{
    public class CrudProductsController : Controller
{
    private readonly ILegoRepository _repo;

    public CrudProductsController(ILegoRepository repo)
    {
        _repo = repo;
    }

    public IActionResult DisplayProducts()
    {
        var products = _repo.GetAllProducts(); // Assuming GetAllProducts is the synchronous version
        return View(products);
    }

    public IActionResult ProductDetails(string id)
    {
        var product = _repo.GetProductById(id); // Assuming GetProductById is the synchronous version
        if (product == null)
        {
            return View("ProductNotFound");
        }
        return View(product);
    }

    [HttpGet]
    public IActionResult CreateProduct()
    {
        return View();
    }

    [HttpPost]
    [ValidateAntiForgeryToken]
    public IActionResult CreateProduct(Product product)
    {
        if (ModelState.IsValid)
        {
            _repo.AddProduct(product); // Assuming AddProduct is the synchronous version
            return RedirectToAction(nameof(DisplayProducts));
        }
        return View(product);
    }

    [HttpGet]
    public IActionResult EditProduct(int id)
    {
        var product = _repo.GetProductById(id.ToString()); // Assuming GetProductById is the synchronous version
        if (product == null)
        {
            return View("ProductNotFound");
        }
        return View(product);
    }

    [HttpPost]
    [ValidateAntiForgeryToken]
    public IActionResult EditProduct(string id, Product product)
    {
        if (id != product.ProductId)
        {
            return View("ProductNotFound");
        }

        if (ModelState.IsValid)
        {
            _repo.UpdateProduct(product); // Assuming UpdateProduct is the synchronous version
            return RedirectToAction(nameof(DisplayProducts));
        }
        return View(product);
    }

    [HttpGet]
    public IActionResult DeleteProduct(string id)
    {
        var product = _repo.GetProductById(id); // Assuming GetProductById is the synchronous version
        if (product == null)
        {
            return View("ProductNotFound");
        }
        return View(product);
    }

    [HttpPost, ActionName("DeleteProduct")]
    [ValidateAntiForgeryToken]
    public IActionResult DeleteConfirmed(string id)
    {
        _repo.DeleteProduct(id); // Assuming DeleteProduct is the synchronous version
        return RedirectToAction(nameof(DisplayProducts));
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}

}
