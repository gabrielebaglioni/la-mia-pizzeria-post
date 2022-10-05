using la_mia_pizzeria_post.Models;
using Microsoft.AspNetCore.Mvc;

namespace la_mia_pizzeria_static.Controllers;

//public class PizzaController : Controller
//{
//    private readonly List<Pizza> pizze = new()
//    {
//        new Pizza
//        {
//            Id = 1,
//            Name = "Margherita",
//            Description = "La classica",
//            Photo = "https://www.melarossa.it/wp-content/uploads/2021/02/ricetta-pizza-margherita.jpg?x58780",
//            Price = 4.00M
//        },

//        new Pizza
//        {
//            Id = 2,
//            Name = "Diavola",
//            Description = "Il Sud",
//            Photo = "https://www.melarossa.it/wp-content/uploads/2021/02/ricetta-pizza-margherita.jpg?x58780",
//            Price = 5.50M
//        },

//        new Pizza
//        {
//            Id = 3,
//            Name = "Boscaiola",
//            Description = "Il nord",
//            Photo = "https://www.melarossa.it/wp-content/uploads/2021/02/ricetta-pizza-margherita.jpg?x58780",
//            Price = 6.00M
//        },

//        new Pizza
//        {
//            Id = 4,
//            Name = "Pizza della casa",
//            Description = "La classica pizza",
//            Photo = "https://www.melarossa.it/wp-content/uploads/2021/02/ricetta-pizza-margherita.jpg?x58780",
//            Price = 8.50M
//        },
//    };

//    // GET
//    public IActionResult Index()
//    {
//        return View(pizze);
//    }

//    public IActionResult Show(int id)
//    {
//        Pizza? pizza = pizze.Find(x => x.Id == id);

//        if (pizza == null)
//        {
//            return View("Error");
//        }

//        return View(pizza);
//    }
//}
public class PizzaController : Controller
{
    protected readonly Context _context;

    public PizzaController( Context context)
    {
        _context = context;
    }
    //GET
        public IActionResult Index()
    {
        List<Pizza> pizzas = _context.Pizzas.ToList();

        return View(pizzas);
    }

    public IActionResult Show(int id)
    {
        Pizza? pizza = _context.Pizzas.First(x => x.Id == id);

        if (pizza == null)
        {
            return View("Error");
        }

        return View(pizza);
    }

    public IActionResult Create()
    {
        return View();
    }

    [HttpPost]
    [ValidateAntiForgeryToken]
    public IActionResult Create(Pizza pizza)
    {
        if (!ModelState.IsValid)
        {
            return View(pizza);
        }

        _context.Pizzas.Add(pizza);
        _context.SaveChanges();

        return RedirectToAction("Id");
    }


}