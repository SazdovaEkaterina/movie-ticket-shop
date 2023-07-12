using Microsoft.AspNetCore.Mvc;
using MovieTicketShop.Service;

namespace MovieTicketShop.Web.Controllers
{
    public class ItemsController : Controller
    {

        private readonly ItemsService _itemsService;

        public ItemsController(ItemsService itemsService)
        {
            _itemsService = itemsService;
        }

         public IActionResult Index()
        {
            return View(this._itemsService.GetAllProducts());
        }

        public IActionResult Details(Guid? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var product = this._itemsService.GetDetailsForItem(id);
            if (product == null)
            {
                return NotFound();
            }

            return View(product);
        }
    }
}
