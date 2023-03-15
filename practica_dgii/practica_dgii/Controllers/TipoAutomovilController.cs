using Core.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TipoAutomovilController : ControllerBase
    {
        private readonly IUnitofwork unitofwork;



        public TipoAutomovilController(IUnitofwork unitofwork)
        {
            this.unitofwork = unitofwork;
        }

        [HttpGet]
        public IActionResult gettipoAutoMovil()
        {
            var vtipoautomovil = unitofwork.TipoAutomovil.GetAll();
            return Ok(vtipoautomovil);
        }
    }
}
