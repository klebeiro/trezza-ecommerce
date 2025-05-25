using chronovault_api.Model.Request;
using chronovault_api.Service.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace chronovault_api.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ProductController : ControllerBase
    {
        private IProductService _productService { get; set; }

        public ProductController(IProductService productService)
        {
            _productService = productService;
        }

        [HttpGet]
        public ActionResult GetAllProducts()
        {
            return Ok(_productService.GetAllProducts());
        }

        [HttpPost]
        public ActionResult CreateProduct(ProductCreateRequest product)
        {
            _productService.CreateProduct(product);

            return Created();
        }
    }
}
