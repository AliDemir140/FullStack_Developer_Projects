using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WebApiCRUD.DTOs;
using WebApiCRUD.Models;

namespace WebApiCRUD.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        private readonly NorthwindContext _context;

        public ProductController(NorthwindContext context)
        {
            _context = context;
        }

        //list
        [HttpGet]
        public IActionResult GetProducts()
        {

            //Product nesnesini ilk etapta DTO olarak dönüştürüp json formatında dışarıya çıkaracağız

            var productsDto = _context.Products.Select(product => new ProductDTO
            {
                ID = product.ProductId,
                ProductName = product.ProductName,
                UnitPrice = product.UnitPrice,
                UnitsInStock = product.UnitsInStock
            });


            return Ok(productsDto.OrderByDescending(x=>x.ID));
        }

        //get by id

        //post
        [HttpPost]
        public IActionResult PostProduct(ProductDTO productDto)
        {
            try
            {
                Product product = new Product
                {
                    ProductId = productDto.ID,
                    ProductName = productDto.ProductName,
                    UnitPrice = productDto.UnitPrice,
                    UnitsInStock = productDto.UnitsInStock
                };

                _context.Products.Add(product);
                _context.SaveChanges();

                return Ok("Ürün eklendi!");
            }
            catch (Exception ex)
            {

                return BadRequest(ex.Message);
            }
        }

        //put

        //delete
    }
}
