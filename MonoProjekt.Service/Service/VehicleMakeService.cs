using AutoMapper;
using MonoProjekt.Service.DAL;
using MonoProjekt.Service.Models;
using MonoProjekt.Service.Models.Common;
using MonoProjekt.Service.Repository.Common;
using MonoProjekt.Service.Service.Common;

namespace MonoProjekt.Service.Service
{
    public class VehicleMakeService : IVehicleMakeService
    {
        #region Constructors

        public VehicleMakeService(IVehicleMakeRepository vehicleMakeRepository, IMapper mapper)
        {
            VehicleMakeRepository = vehicleMakeRepository;
            Mapper = mapper;
        }

        #endregion Constructors

        #region Properties

        public IMapper Mapper { get; set; }
        public IVehicleMakeRepository VehicleMakeRepository { get; set; }

        #endregion Properties

        #region Methods

        public async Task<bool> DeleteVehicleMakerAsync(Guid id)
        {
            var result = await VehicleMakeRepository.DeleteAsync(id);
            return result;
        }

        public async Task<VehicleMake> FindVehicleMakerAsync(Guid id)
        {
            var result = VehicleMakeRepository.FindAsync(id);
            return Mapper.Map<VehicleMake>(result);
        }

        public async Task<bool> InsertVehicleMakerAsync(VehicleMake vehicleMake)
        {
            CreateVehicleMaker(vehicleMake);
            var entity = Mapper.Map<VehicleMakeEntity>(vehicleMake);
            var result = await VehicleMakeRepository.InsertAsync(entity);
            return result;
        }

        public async Task<bool> UpdateVehicleMakerAsync(VehicleMake vehicleMake)
        {
            var entity = Mapper.Map<VehicleMakeEntity>(vehicleMake);
            var result = await VehicleMakeRepository.UpdateAsync(entity);
            return result;
        }

        private void CreateVehicleMaker(VehicleMake vehicleMake)
        {
            vehicleMake.Id = Guid.NewGuid();
            vehicleMake.Abrv = vehicleMake.Name.ToLower().Replace(" ", "-").Replace("č", "c").Replace("ć", "c").Replace("ž", "z").Replace("š", "s").Replace("đ", "d");
        }

        #endregion Methods
    }
}
