using AutoMapper;
using MonoProjekt.Service.DAL;
using MonoProjekt.Service.Models;
using MonoProjekt.Service.Repository.Common;
using MonoProjekt.Service.Service.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MonoProjekt.Service.Service
{
    public class VehicleModelService : IVehicleModelService
    {
        #region Constructors

        public VehicleModelService(IVehicleModelRepository vehicleModelRepository, IMapper mapper)
        {
            VehicleModelRepository = vehicleModelRepository;
            Mapper = mapper;
        }

        #endregion Constructors

        #region Properties

        public IMapper Mapper { get; set; }
        public IVehicleModelRepository VehicleModelRepository { get; set; }

        #endregion Properties

        #region Methods

        public async Task<bool> DeleteVehicleModelAsync(Guid id)
        {
            var result = await VehicleModelRepository.DeleteAsync(id);
            return result;
        }

        public async Task<VehicleModel> FindVehicleModelAsync(Guid id)
        {
            var result = await VehicleModelRepository.FindAsync(id);
            return Mapper.Map<VehicleModel>(result);
        }

        public async Task<bool> InsertVehicleModelAsync(VehicleModel vehicleModel)
        {
            CreateVehicleModel(vehicleModel);
            var entity = Mapper.Map<VehicleModelEntity>(vehicleModel);
            var result = await VehicleModelRepository.UpdateAsync(entity);
            return result;
        }

        public async Task<bool> UpdateVehicleModelAsync(VehicleModel vehicleModel)
        {
            var entity = Mapper.Map<VehicleModelEntity>(vehicleModel);
            var result = await VehicleModelRepository.UpdateAsync(entity);
            return result;
        }

        private void CreateVehicleModel(VehicleModel vehicleModel)
        {
            vehicleModel.Id = Guid.NewGuid();
            vehicleModel.Abrv = vehicleModel.Name.ToLower().Replace(" ", "-").Replace("č", "c").Replace("ć", "c").Replace("ž", "z").Replace("š", "s").Replace("đ", "d");
        }

        #endregion Methods
    }
}
