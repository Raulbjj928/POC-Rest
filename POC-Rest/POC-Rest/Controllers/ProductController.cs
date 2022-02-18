using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using POC_Rest.Model;
using POC_Rest.Services;

namespace POC_Rest.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ProductController : ControllerBase
    {
        private readonly ILogger<ProductController> _logger;
        private IProductService _productService;

        public ProductController(ILogger<ProductController> logger, IProductService productService)
        {
            _logger = logger;
            _productService = productService;
        }

        [HttpGet]
        public IActionResult Get()
        {
            return Ok(_productService.FindAll());
        }
        
        [HttpGet("{id}")]
        public IActionResult Get(long id)
        {
            var product = _productService.FindById(id);
            if (product == null) return NotFound();
            return Ok(product);
        }

        [HttpPost]
        public IActionResult Post([FromBody] Product product)
        {
            if (product == null) return BadRequest();
            return Ok(_productService.Create(product));
        }

        [HttpPut]
        public IActionResult Put([FromBody] Product product)
        {
            if (product == null) return BadRequest();
            return Ok(_productService.Update(product));
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(long id)
        {
            _productService.Delete(id);
            return NoContent();
        }
    }
}
