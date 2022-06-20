using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MonoProjekt.Service.Models;

namespace MonoProjekt.Service.Service.Common
{
    public interface IVehicleModelService
    {
        #region Methods

        Task<bool> DeleteVehicleModelAsync(Guid id);

        Task<VehicleModel> FindVehicleModelAsync(Guid id);

        Task<bool> InsertVehicleModelAsync(VehicleModel vehicleModel);

        Task<bool> UpdateVehicleModelAsync(VehicleModel vehicleModel);

        #endregion Methods
    }
}
