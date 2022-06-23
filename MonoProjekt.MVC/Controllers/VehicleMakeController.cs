using System.Collections.Generic;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using MonoProjekt.Service.DAL;
using MonoProjekt.Service.Models;
using MonoProjekt.Service.Service.Common;

namespace MonoProjekt.MVC.Controllers
{
    public class VehicleMakeController : Controller
    {
        #region Fields

        private readonly MonoProjektContext Context;

        #endregion Fields

        #region Constructors

        public VehicleMakeController(IVehicleMakeService vehicleMakeService, IMapper mapper, MonoProjektContext context)
        {
            VehicleMakeService = vehicleMakeService;
            Mapper = mapper;
            Context = context;
        }

        #endregion Constructors

        #region Properties

        public IMapper Mapper { get; set; }
        public IVehicleMakeService VehicleMakeService { get; set; }

        #endregion Properties

        #region Methods

        public IActionResult Create()
        {
            return View();
        }

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

        public IActionResult Index()
        {
            var result = VehicleMakeService.GetAllVehicleMakers();
            if (result != null)
            {
                var restModel = Mapper.Map<List<VehicleMakeRestModel>>(result);
                return View(restModel);
            }
            return BadRequest();
        }

        [HttpPost]
        public async Task<ActionResult<VehicleMake>> PostVehicleMaker([FromBody] VehicleMake vehicleMake)
        {
            var newVehicleMaker = await VehicleMakeService.InsertVehicleMakerAsync(vehicleMake);
            return Ok(newVehicleMaker);
        }

        public IActionResult Privacy()
        {
            return View();
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

        #region Classes

        public class VehicleMakeRestModel
        {
            #region Properties

            public string Abrv { get; set; }
            public Guid Id { get; set; }
            public string Name { get; set; }

            #endregion Properties
        }

        #endregion Classes
    }
}
