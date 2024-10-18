using ConcessionaireAppServer.BusinessLayer;
using DTOs.Entities;
using Microsoft.AspNetCore.Mvc;

namespace ConcessionaireAppServer.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ConcessionaireAppController : ControllerBase
    {
        private readonly ILogger<ConcessionaireAppController> _logger;
        private readonly IBusinessServices _businessServices;

        public ConcessionaireAppController(ILogger<ConcessionaireAppController> logger, IBusinessServices businessServices)
        {
            _logger = logger;
            _businessServices = businessServices;
        }

        [HttpGet]
        [Route("/[controller]/[action]")]
        public async Task<IActionResult> GetBrands()
        {
            try
            {
                return Ok(await _businessServices.GetBrands());
            }
            catch (Exception)
            {
                return StatusCode(500);
            }
        }

        [HttpPost]
        [Route("/[controller]/[action]")]
        public async Task<IActionResult> CreateNewBrand([FromBody] BrandResponse brand)
        {
            try
            {
                return Ok(await _businessServices.CreateNewBrand(brand));
            }
            catch (NullReferenceException)
            {
                return BadRequest();
            }
            catch (ArgumentException)
            {
                return BadRequest();
            }
            catch (Exception)
            {
                return StatusCode(500);
            }
        }

        [HttpGet]
        [Route("/[controller]/[action]")]
        public async Task<IActionResult> GetSales()
        {
            try
            {
                return Ok(await _businessServices.GetSales());
            }
            catch (Exception)
            {
                return StatusCode(500);
            }
        }

        [HttpGet]
        [Route("/[controller]/[action]/{sellerId}")]
        public async Task<IActionResult> GetSalesBySellerId(int sellerId)
        {
            try
            {
                return Ok(await _businessServices.GetSalesBySellerId(sellerId));
            }
            catch (Exception)
            {
                return StatusCode(500);
            }
        }

        [HttpDelete]
        [Route("/[controller]/[action]/{id}")]
        public async Task<IActionResult> DeleteSale(int id)
        {
            try
            {
                return Ok(await _businessServices.DeleteSale(id));
            }
            catch (Exception ex)
            {
                if (ex.Message == "Element to delete not found")
                {
                    return BadRequest();
                }
                else
                {
                    return StatusCode(500);
                }
            }
        }

        [HttpGet]
        [Route("/[controller]/[action]")]
        public async Task<IActionResult> GetSellers()
        {
            try
            {
                return Ok(await _businessServices.GetSellers());
            }
            catch (Exception)
            {
                return StatusCode(500);
            }
        }

        [HttpGet]
        [Route("/[controller]/[action]/{id}")]
        public async Task<IActionResult> GetSellerById(int id)
        {
            try
            {
                return Ok(await _businessServices.GetSellerById(id));
            }
            catch (Exception)
            {
                return StatusCode(500);
            }
        }

        [HttpPut]
        [Route("/[controller]/[action]")]
        public async Task<IActionResult> UpdateSeller([FromBody] SellerResponse seller)
        {
            try
            {
                return Ok(await _businessServices.UpdateSeller(seller));
            }
            catch (NullReferenceException)
            {
                return BadRequest();
            }
            catch (ArgumentException)
            {
                return BadRequest();
            }
            catch (Exception)
            {
                return StatusCode(500);
            }
        }
    }
}
