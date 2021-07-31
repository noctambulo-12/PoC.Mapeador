using Mapster;
using Microsoft.AspNetCore.Mvc;
using PoC.Mapeador.Mapster.Models;

namespace PoC.Mapeador.Mapster.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ProductController : ControllerBase
    {
        [HttpPost]
        public IActionResult CreateProduct(ProductRequest request)
        {
            //Mapeo basico
            //Product productResponse1 = request.Adapt<ProductResponse>();

            //Mapeo con configuración 
            var productResponse = request.Adapt<ProductResponse>(MappingConfig.GetTypeAdapterConfig());

            return Ok(productResponse);
        }
    }
}