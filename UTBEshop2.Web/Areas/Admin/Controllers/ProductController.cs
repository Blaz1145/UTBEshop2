using Microsoft.AspNetCore.Mvc;
using UTBEshop2.Application.Abstraction;
using UTBEshop2.Domain.Entities;

namespace UTBEshop2.Web.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class ProductController : Controller //: Controller je základná trieda z ASP.NET Core, k dispozícii napríklad View()
    {
        readonly IProductAppService _productAppService;
        public ProductController(IProductAppService productAppService)
        {
            _productAppService = productAppService;
        }
        
        public IActionResult Select()
        {
            var products = _productAppService.SelectAll();
            return View(products); //nájde view podľa konvencie Views/{Controller}/{Akcia}.cshtml, teda Areas/Admin/Views/Product/Select.cshtml
        }
        
        public IActionResult Create() // akcia (GET) sa spustí po otvorení stránky a zobrazí prázdny formulár.
        {
            return View();
        }
        
        [HttpPost]
        public IActionResult Create(Product product) 
        {
            _productAppService.Create(product);
            return RedirectToAction(nameof(Select));
        }
        
        /*[HttpPost] sa spustí po kliknutí na Odoslať.
            ASP.NET z polí formulára sám poskladá objekt Product. Tomu sa hovorí model binding.
            Po uložení presmeruje na zoznam produktov (Select).*/
    }
}