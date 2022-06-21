using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MonoProjekt.Service.Models;
using MonoProjekt.Service.Service.Common;

namespace MonoProjekt.Service.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class VehicleModelController : ControllerBase
    {
        #region Constructors

        public VehicleModelController(IVehicleModelService vehicleModelService, IMapper mapper)
        {
            VehicleModelService = vehicleModelService;
            Mapper = mapper;
        }

        #endregion Constructors

        #region Properties

        public IMapper Mapper { get; set; }
        public IVehicleModelService VehicleModelService { get; set; }

        #endregion Properties

        #region Methods

        [HttpDelete("{id}")]
        public async Task<ActionResult> DeleteVehicleModel(Guid id)
        {
            var vehicleModel = await VehicleModelService.FindVehicleModelAsync(id);
            if (vehicleModel == null)
            {
                return NotFound();
            }
            await VehicleModelService.DeleteVehicleModelAsync(vehicleModel.Id);
            return NoContent();
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<VehicleModel>> FindVehicleModel(Guid id)
        {
            return await VehicleModelService.FindVehicleModelAsync(id);
        }

        [HttpPost]
        public async Task<ActionResult<VehicleModel>> PostVehicleModel([FromBody] VehicleModel vehicleModel)
        {
            return await VehicleModelService.InsertVehicleModelAsync(vehicleModel);
        }

        [HttpPut]
        public async Task<ActionResult> PutVehicleModel(Guid id, [FromBody] VehicleModel vehicleModel)
        {
            if (id != vehicleModel.Id)
            {
                return BadRequest();
            }

            await VehicleModelService.UpdateVehicleModelAsync(vehicleModel);
            return Ok();
        }

        #endregion Methods
    }
}
