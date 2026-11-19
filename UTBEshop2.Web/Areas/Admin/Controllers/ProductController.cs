using Microsoft.AspNetCore.Mvc;
using UTBEshop2.Application.Abstraction;

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
    }
}