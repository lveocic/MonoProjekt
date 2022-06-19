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

        Task<bool> DeleteAsync(Guid id);

        Task<VehicleModel> FindAsync(Guid id);

        Task<bool> InsertAsync(VehicleModelEntity entity);

        Task<bool> UpdateAsync(VehicleModelEntity entity);

        #endregion Methods
    }
}