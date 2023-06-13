using Microsoft.AspNetCore.Mvc;
using PizzaApp.Models.Domain;

namespace PizzaApp.Controllers
{
    public class OrderHomeworkController : Controller
    {
        [Route("ListOrders")]
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Details(int? id)
        {
            if (id == null)
            {
                return new EmptyResult();
            }

            OrderHomework orderHomework = StaticDbOrdersHomework.Orders.FirstOrDefault(x => x.Id == id);

            if (orderHomework == null)
            {
                return new EmptyResult();
            }

            return View(orderHomework);

        }

        public IActionResult JsonData()
        {
            OrderHomework orderHomework = new(1, "Tasty Pizza");
            return new JsonResult(orderHomework);
        }

        public IActionResult RedirectToHomeIndex()
        {
            return RedirectToAction("Index", "Home");
        }
    }
}
