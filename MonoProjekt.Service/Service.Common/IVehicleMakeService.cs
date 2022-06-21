using MonoProjekt.Service.Models;

namespace MonoProjekt.Service.Service.Common
{
    public interface IVehicleMakeService
    {
        #region Methods

        Task DeleteVehicleMakerAsync(Guid id);

        Task<VehicleMake> FindVehicleMakerAsync(Guid id);

        Task<VehicleMake> InsertVehicleMakerAsync(VehicleMake vehicleMake);

        Task UpdateVehicleMakerAsync(VehicleMake vehicleMake);

        #endregion Methods
    }
}
