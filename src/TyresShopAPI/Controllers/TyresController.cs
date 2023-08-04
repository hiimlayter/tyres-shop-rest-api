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
        public async Task<IActionResult> GetAllTyres()
        {
            var result = await _tyresService.GetAllTyres();
            
            return Ok(result);
        }

        [HttpPost]
        [Route("AddOrUpdateTyre")]
        public async Task<IActionResult> AddOrUpdateTyre(TyreCreate model)
        {
            try
            {
                await _tyresService.AddOrUpdateTyre(model);

            }
            catch (Exception ex)
            {
                throw new Exception(ex.ToString());
            }

            return Ok();
        }

        [HttpGet]
        [Route("GetTyresById/{tyreId}")]
        public async Task<IActionResult> GetTyresById(int tyreId)
        {
            var result = await _tyresService.GetTyreBydId(tyreId);

            return Ok(result);
        }

        [HttpDelete]
        [Route("DeleteTyreById/{tyreId}")]
        public async Task<IActionResult> DeleteContactById(int tyreId)
        {
            try
            {
                await _tyresService.DeleteTyreById(tyreId);
            }
            catch (Exception e)
            {
                throw new Exception(e.ToString());
            }


            return Ok();
        }

    }
}
