using CdekAPI.Dto;
using CdekAPI.Models;
using CdekAPI.Services.Contracts;
using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Mvc;


namespace CdekAPI.Controllers
{
    [Microsoft.AspNetCore.Mvc.Route("api/[controller]")]
    [ApiController]
    public class СdekController :Controller
    {
        private readonly ICostCalculation _costCalculation;
        public СdekController(ICostCalculation costCalculation)
        {
            _costCalculation = costCalculation;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="weight"></param>
        /// <param name="height_mm"></param>
        /// <param name="length_mm"></param>
        /// <param name="width_mm"></param>
        /// <param name="from_location"></param>
        /// <param name="to_location"></param>
        /// <returns></returns>
        [HttpPost]
        public async Task<ActionResult<TariffsInfoDto>> GetDeliveryPrice(int weight, int height_mm,
            int length_mm, int width_mm, int from_location, int to_location)
        {
           
           var result = await _costCalculation.GetCostAsync(weight, height_mm,
            length_mm, width_mm, from_location, to_location);
            if (result == null)
            {
                return NotFound();
            }
            return Ok(result);
        }
    }
}
