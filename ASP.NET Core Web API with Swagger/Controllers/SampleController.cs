using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using ASP.NET_Core_Web_API_with_Swagger.Model;

/// <summary>
/// Reference: https://www.c-sharpcorner.com/blogs/net-core-api-with-swagger-documentation
/// </summary>
namespace ASP.NET_Core_Web_API_with_Swagger.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SampleController : ControllerBase
    {
        public List<SampleModel> Data = new List<SampleModel>();
        public List<Products> Product = new List<Products>();
        public SampleController()
        {
            Product = new List<Products>()
            {
                new Products(){ProductNo = "001", ProductType = "fruit" },
                new Products(){ProductNo = "002", ProductType = "vegetable" },
                new Products(){ProductNo = "003", ProductType = "meat" }
            };

            Data = new List<SampleModel>()
            {
                new SampleModel(){Id = 1, Product = Product[0] },
                new SampleModel(){Id = 2, Product = Product[1] },
                new SampleModel(){Id = 3, Product = Product[2] }
            };
        }

        [HttpGet]
        [Route("GetAllProducts")]
        public IActionResult GetAllProducts()
        {
            return Ok(Data);
        }

        [HttpGet]
        [Route("GetAllProducts/{id}")]
        public IActionResult GetProductDetail(int id)
        {
            var result = Data.Where(x => x.Id == id);
            if (result.Count() == 0)
                return NoContent();
            return Ok(result);
        }

        [HttpPost]
        [Route("PostProducts")]
        public IActionResult PostProducts(SampleModel model)
        {
            Data.Add(model);
            return Ok(Data);
        }
    }
}
