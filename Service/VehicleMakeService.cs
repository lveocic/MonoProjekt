using AutoMapper;
using MonoProjekt.Service.Repository.Common;
using MonoProjekt.Service.Service.Common;

namespace MonoProjekt.Service.Service
{
    public class VehicleMakeService : IVehicleMakeService
    {
        #region Constructors

        public VehicleMakeService(IVehicleMakeRepository vehicleMakeRepository)
        {
            VehicleMakeRepository = vehicleMakeRepository;
        }

        #endregion Constructors

        #region Properties

        public IVehicleMakeRepository VehicleMakeRepository { get; set; }

        #endregion Properties
    }
}