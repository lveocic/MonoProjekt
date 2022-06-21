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

        Task DeleteVehicleModelAsync(Guid id);

        Task<VehicleModel> FindVehicleModelAsync(Guid id);

        Task<VehicleModel> InsertVehicleModelAsync(VehicleModel vehicleMake);

        Task UpdateVehicleModelAsync(VehicleModel vehicleMake);

        #endregion Methods
    }
}
