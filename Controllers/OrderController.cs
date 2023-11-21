using Microsoft.AspNetCore.Mvc;

public class OrderController : Controller
{
    public IActionResult Register()
    {
        return View();
    }

    [HttpPost]
    public IActionResult Register(User user)
    {
        if (user.Age > 16)
        {
            ViewBag.ShowQuantityField = true;
            return View("Order", new List<Product>()); 
        }
        else
        {
            ViewBag.ShowQuantityField = false;
            return View("Order", null); 
        }
    }

    [HttpPost]
    public IActionResult Order(List<Product> products)
    {
        return View(products);
    }
}
