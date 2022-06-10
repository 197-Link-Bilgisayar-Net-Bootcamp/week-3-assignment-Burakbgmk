using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using NLayerData.Models;
using NLayerService;
using NLayerService.Dtos;

namespace NLayerApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        private readonly ProductService _productService;
        public ProductController(ProductService productService)
        {
            _productService = productService;
        }
        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            var response = await _productService.GetAll();
            return new ObjectResult(response) { StatusCode = response.Status};
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetById(int id)
        {
            var response = await _productService.GetById(id);
            return new ObjectResult(response) { StatusCode = response.Status};
        }

        [HttpGet("GetFullModel")]
        public async Task<IActionResult> GetFullModel()
        {
            var response = await _productService.GetFullModel();
            return new ObjectResult(response) { StatusCode = response.Status };
        }

        [HttpPost]
        public async Task<IActionResult> CreateProduct(ProductDto product)
        {
            var response = await _productService.Create(product);
            return new ObjectResult(response) { StatusCode = response.Status };
        }

        [HttpPost("CreateWithFeatures")]
        public async Task<IActionResult> CreateWithFeatures(ProductDto productDto, [FromHeader] ProductFeatureDto productFeatureDto)
        {
            var response = await _productService.CreateWithFeatures(productDto, productFeatureDto);
            return new ObjectResult(response) { StatusCode = response.Status };
        }

        [HttpPut]
        public async Task<IActionResult> UpdateProduct(int id, ProductDto productDto)
        {
            var response = await _productService.Update(id, productDto);
            return new ObjectResult(response) { StatusCode = response.Status };
        }

        [HttpDelete("{id}")]
        public IActionResult DeleteProduct(int id)
        {
            var response = _productService.Delete(id);
            return new ObjectResult(response) { StatusCode = response.Status };
        }

    }
}
