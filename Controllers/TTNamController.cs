
using DAFramework.Services;
using Microsoft.AspNetCore.Mvc;
using DAFramework.Controllers;

namespace DAFramework.Controllers
{
    public class TTNamController : Controller 
    {
        private readonly ILogger<TTNamController> _logger;

        private readonly ProductService _productService;

        public TTNamController(ILogger<TTNamController> logger, ProductService productService){
            _logger = logger;
            _productService = productService;
        }
        public IActionResult Index(){
            return View();
        }

        public IActionResult Test(){
            var product = from p in _productService select p;
            if(product == null){
                TempData["StatusMessage"] = "Sản phẩm không tồn tại!";
                return Redirect(Url.Action("Index", "Home"));
            }
            
            return View("xinchao1", product);
        }

        [HttpGet]
        public IActionResult anything(int? id){
            var product = _productService.Where(p => p.ID == id).FirstOrDefault();
            if(product == null){
                TempData["StatusMessage"] = "Sản phẩm không tồn tại!";
                return Redirect(Url.Action("Index", "Home"));
            }
            return View("xinchao1", product);
        }
    }
}