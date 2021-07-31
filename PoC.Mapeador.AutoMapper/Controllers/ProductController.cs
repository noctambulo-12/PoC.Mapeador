using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using PoC.Mapeador.AutoMapper.Models;

namespace PoC.Mapeador.AutoMapper.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ProductController : ControllerBase
    {
        private readonly IMapper _mapper;

        public ProductController(IMapper mapper)
        {
            _mapper = mapper;
        }

        [HttpPost]
        public IActionResult CreateProduct(ProductRequest request)
        {
            var product = _mapper.Map<ProductResponse>(request);

            return Ok(product);
        }
    }
}