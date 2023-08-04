using Microsoft.AspNetCore.Mvc;
using TyresShopAPI.Interfaces;
using TyresShopAPI.Models;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace TyresShopAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TyresController : ControllerBase
    {
        private ITyresService _tyresService;

        public TyresController(ITyresService tyresService)
        {
            _tyresService = tyresService;
        }

        [HttpGet]
        [Route("GetAllTyres")]
        public IActionResult GetAllTyres()
        {
            return Ok();
        }

        [HttpPost]
        [Route("AddTyre")]
        public async Task<IActionResult> AddTyre(TyreCreate model)
        {
            try
            {
                await _tyresService.AddTyre(model);

            }
            catch (Exception ex)
            {
                throw new Exception(ex.ToString());
            }

            return Ok();
        }

        [HttpPut]
        [Route("UpdateTyre")]
        public async Task<IActionResult> UpdateTyre(TyreCreate model, int tyreId)
        {
            try
            {
                await _tyresService.UpdateTyre(model, tyreId);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.ToString());
            }

            return Ok();
        }

        [HttpDelete]
        [Route("DeleteTyre")]
        public async Task<IActionResult> DeleteTyre(int tyreId)
        {
            try
            {
                await _tyresService.DeleteTyre(tyreId);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.ToString());
            }

            return Ok();
        }

        [HttpGet]
        [Route("GetTyre")]
        public async Task<IActionResult> GetTyre(int tyreId)
        {
            try
            {
                return Ok(await _tyresService.GetTyre(tyreId));
            }
            catch (Exception ex)
            {
                throw new Exception(ex.ToString());
            }
        }
    }
}
