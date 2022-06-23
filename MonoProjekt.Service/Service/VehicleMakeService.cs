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

        public async Task DeleteVehicleMakerAsync(Guid id)
        {
            await VehicleMakeRepository.DeleteAsync(id);
        }

        public async Task<VehicleMake> FindVehicleMakerAsync(Guid id)
        {
            var result = VehicleMakeRepository.FindAsync(id);
            return Mapper.Map<VehicleMake>(result);
        }

        public async Task<IEnumerable<VehicleMake>> GetAllVehicleMakers()
        {
            var result = await VehicleMakeRepository.GetAllAsync();
            return result;
        }

        public async Task<VehicleMake> InsertVehicleMakerAsync(VehicleMake vehicleMake)
        {
            CreateVehicleMaker(vehicleMake);
            var entity = Mapper.Map<VehicleMakeEntity>(vehicleMake);
            var result = await VehicleMakeRepository.InsertAsync(entity);
            return result;
        }

        public async Task UpdateVehicleMakerAsync(VehicleMake vehicleMake)
        {
            var entity = Mapper.Map<VehicleMakeEntity>(vehicleMake);
            await VehicleMakeRepository.UpdateAsync(entity);
        }

        private void CreateVehicleMaker(VehicleMake vehicleMake)
        {
            vehicleMake.Id = Guid.NewGuid();
            vehicleMake.Abrv = vehicleMake.Name.ToLower().Replace(" ", "-").Replace("č", "c").Replace("ć", "c").Replace("ž", "z").Replace("š", "s").Replace("đ", "d");
        }

        #endregion Methods
    }
}
