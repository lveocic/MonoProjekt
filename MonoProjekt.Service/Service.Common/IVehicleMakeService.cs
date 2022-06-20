using MonoProjekt.Service.Models;

namespace MonoProjekt.Service.Service.Common
{
    public interface IVehicleMakeService
    {
        #region Methods

        Task<bool> DeleteVehicleMakerAsync(Guid id);

        Task<VehicleMake> FindVehicleMakerAsync(Guid id);

        Task<bool> InsertVehicleMakerAsync(VehicleMake vehicleMake);

        Task<bool> UpdateVehicleMakerAsync(VehicleMake vehicleMake);

        #endregion Methods
    }
}
