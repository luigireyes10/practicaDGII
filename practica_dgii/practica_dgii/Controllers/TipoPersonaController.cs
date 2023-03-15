using Core.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TipoPersonaController : ControllerBase
    {
        private readonly IUnitofwork unitofwork;

    

        public TipoPersonaController(IUnitofwork unitofwork)
        {
            this.unitofwork = unitofwork;
        }


        [HttpGet]
        public IActionResult  gettipoPersona()
        {
            var vtipopersona = unitofwork.TipoPersona.GetAll();
            return Ok(vtipopersona);
        }

    }
}
