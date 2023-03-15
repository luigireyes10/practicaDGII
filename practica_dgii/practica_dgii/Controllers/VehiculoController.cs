using Core.Interfaces;
using Core.Models;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers
{

    [Route("api/[controller]")]
    [ApiController]
    public class VehiculoController : ControllerBase
    {
        private readonly IUnitofwork unitofwork;



        public VehiculoController(IUnitofwork unitofwork)
        {
            this.unitofwork = unitofwork;
        }

        [HttpGet]
        public IActionResult getVehiculo()
        {
            var vvehiculo = unitofwork.Vehiculo.GetAll();
            return Ok(vvehiculo);
        }


        [HttpGet]
        public IActionResult getIdVehiculo([FromQuery] int id)
        {
            var vvehiculo = unitofwork.Vehiculo.GetById(id);
            return Ok(vvehiculo);
        }


        [HttpPost]
        public IActionResult CreateVehiculo([FromBody] Vehiculo vehiculo)
        {
            unitofwork.Vehiculo.Add(vehiculo);
            unitofwork.Save();
             return Ok(vehiculo);
        }


        [HttpPut]
        public IActionResult UpdateVehiculo([FromBody] Vehiculo vehiculo)
        {
            unitofwork.Vehiculo.Update(vehiculo);
            unitofwork.Save();
            return Ok(vehiculo);
        }
    }
}
