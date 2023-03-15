using AutoMapper;
using Core.Interfaces;
using Core.Models;
using Data.Repositorio;
using Microsoft.AspNetCore.Mvc;
using System.Net;
using System.Numerics;

namespace API.Controllers
{
  
        [Route("api/[controller]")]
        [ApiController]
        public class PlacaVehiculoController : ControllerBase
        {
            private readonly IUnitofwork unitofwork;


        private readonly IMapper _mapper;
        public PlacaVehiculoController(IUnitofwork unitofwork)
            {
                this.unitofwork = unitofwork;
            }

            [HttpGet]
         public IActionResult getPlacaVehiculo()
         {
              var vplacavehiculo = unitofwork.PlacaVehiculo.GetAll();
              return Ok(vplacavehiculo);
         }


        [HttpGet]
        public IActionResult getIdPlacaVehiculo([FromQuery] int cedula)
        {

            var entity = unitofwork.PlacaVehiculo.GetById(cedula);
          

        var model = _mapper.Map<PlacaVehiculoCustom>(entity);

            return Ok(model);
        }


        [HttpPost]
        public IActionResult CreatePlacavehiculo([FromBody] PlacaVehiculo placavehiculo)
        {
            unitofwork.PlacaVehiculo.Add(placavehiculo);
            unitofwork.Save();
             return Ok();
        }


        [HttpPut]
        public IActionResult UpdatePlacaVehiculo([FromBody] PlacaVehiculo placavehiculo)
        {
            unitofwork.PlacaVehiculo.Update(placavehiculo);
            unitofwork.Save();
            return Ok();
        }
    }
    
}
