using AutoMapper;
using MonoProjekt.Service.DAL;
using MonoProjekt.Service.Models;
using MonoProjekt.Service.Repository.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MonoProjekt.Service.Repository
{
    public class VehicleModelRepository : IVehicleModelRepository
    {
        #region Fields

        private MonoProjektContext Context;

        #endregion Fields

        #region Constructors

        public VehicleModelRepository(MonoProjektContext context, IMapper mapper)
        {
            Context = context;
            Mapper = mapper;
        }

        #endregion Constructors

        #region Properties

        public IMapper Mapper { get; set; }

        #endregion Properties

        #region Methods

        public async Task<bool> DeleteAsync(Guid id)
        {
            var vehicleModel = Context.VehicleModels.Find(id);
            if (vehicleModel == null)
                return false;
            Context.VehicleModels.Remove(vehicleModel);
            await Context.SaveChangesAsync();
            return true;
        }

        public async Task<VehicleModel> FindAsync(Guid id)
        {
            return Mapper.Map<VehicleModel>(await Context.VehicleMakers.FindAsync(id));
        }

        public async Task<bool> InsertAsync(VehicleModelEntity entity)
        {
            if (entity == null)
            {
                return false;
            }
            else
            {
                var insert = await Context.AddAsync(entity);
                return await Context.SaveChangesAsync() > 0;
            }
        }

        public async Task<bool> UpdateAsync(VehicleModelEntity entity)
        {
            if (entity == null)
            {
                return false;
            }
            else
            {
                var update = Context.Update(entity);
                return await Context.SaveChangesAsync() > 0;
            }
        }

        #endregion Methods
    }
}
