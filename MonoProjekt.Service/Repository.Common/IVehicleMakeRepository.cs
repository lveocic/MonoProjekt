using MonoProjekt.Service.DAL;
using MonoProjekt.Service.Models;

namespace MonoProjekt.Service.Repository.Common
{
    public interface IVehicleMakeRepository
    {
        #region Methods

        Task DeleteAsync(Guid id);

        Task<VehicleMake> FindAsync(Guid id);

        Task<VehicleMake> InsertAsync(VehicleMakeEntity entity);

        Task UpdateAsync(VehicleMakeEntity entity);

        #endregion Methods
    }
}