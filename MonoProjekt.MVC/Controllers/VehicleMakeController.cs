using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using MonoProjekt.Service.Models;
using MonoProjekt.Service.Service.Common;

namespace MonoProjekt.MVC.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class VehicleMakeController : ControllerBase
    {
        #region Constructors

        public VehicleMakeController(IVehicleMakeService vehicleMakeService, IMapper mapper)
        {
            VehicleMakeService = vehicleMakeService;
            Mapper = mapper;
        }

        #endregion Constructors

        #region Properties

        public IMapper Mapper { get; set; }
        public IVehicleMakeService VehicleMakeService { get; set; }

        #endregion Properties

        #region Methods

        [HttpDelete("{id}")]
        public async Task<ActionResult> DeleteVehicleMaker(Guid id)
        {
            var vehicleMaker = await VehicleMakeService.FindVehicleMakerAsync(id);
            if (vehicleMaker == null)
            {
                return NotFound();
            }
            await VehicleMakeService.DeleteVehicleMakerAsync(vehicleMaker.Id);
            return NoContent();
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<VehicleMake>> FindVehicleMaker(Guid id)
        {
            return await VehicleMakeService.FindVehicleMakerAsync(id);
        }

        [HttpPost]
        public async Task<ActionResult<VehicleMake>> PostVehicleMaker([FromBody] VehicleMake vehicleMake)
        {
            var newVehicleMaker = await VehicleMakeService.InsertVehicleMakerAsync(vehicleMake);
            return Ok(newVehicleMaker);
        }

        [HttpPut]
        public async Task<ActionResult> PutVehicleMaker(Guid id, [FromBody] VehicleMake vehicleMake)
        {
            if (id != vehicleMake.Id)
            {
                return BadRequest();
            }

            await VehicleMakeService.UpdateVehicleMakerAsync(vehicleMake);
            return Ok();
        }

        #endregion Methods
    }
}
