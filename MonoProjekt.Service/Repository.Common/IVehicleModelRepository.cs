using MonoProjekt.Service.DAL;
using MonoProjekt.Service.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MonoProjekt.Service.Repository.Common
{
    public interface IVehicleModelRepository
    {
        #region Methods

        Task DeleteAsync(Guid id);

        Task<VehicleModel> FindAsync(Guid id);

        Task<VehicleModel> InsertAsync(VehicleModelEntity entity);

        Task UpdateAsync(VehicleModelEntity entity);

        #endregion Methods
    }
}
