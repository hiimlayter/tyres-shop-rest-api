using Microsoft.AspNetCore.Mvc;
using TyresShopAPI.Models;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace TyresShopAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TyresController : ControllerBase
    {
        private readonly List<Tyres> tyresList = new()
        {
            new Tyres(new Producer("Pirelli", "Germany"), "P1", 490M, 2022, 50, 16, 16, TyresType.Summer),
            new Tyres(new Producer("Pirelli", "Germany"), "P2", 123.50M, 2021, 50, 16, 16, TyresType.Winter),
            new Tyres(new Producer("Pirelli", "Germany"), "P3", 450M, 2023, 50, 16, 16, TyresType.Summer)
        };

        public TyresController()
        {

        }

        [HttpGet]
        [Route("GetAllTyres")]
        public IActionResult GetAllTyres()
        {
            var result = tyresList.ToList();

            return Ok(result);
        }

    }
}
