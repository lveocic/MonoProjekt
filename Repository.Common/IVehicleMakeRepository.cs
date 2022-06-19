using MonoProjekt.Service.DAL;
using MonoProjekt.Service.Models;

namespace MonoProjekt.Service.Repository.Common
{
    public interface IVehicleMakeRepository
    {
        #region Methods

        Task<bool> DeleteAsync(Guid id);

        Task<VehicleMake> FindAsync(Guid id);

        Task<bool> InsertAsync(VehicleMakeEntity entity);

        Task<bool> UpdateAsync(VehicleMakeEntity entity);

        #endregion Methods
    }
}