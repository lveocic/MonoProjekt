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

        public async Task DeleteAsync(Guid id)
        {
            var vehicleModel = Context.VehicleModels.Find(id);
            Context.VehicleModels.Remove(vehicleModel);
            await Context.SaveChangesAsync();
        }

        public async Task<VehicleModel> FindAsync(Guid id)
        {
            return Mapper.Map<VehicleModel>(await Context.VehicleModels.FindAsync(id));
        }

        public async Task<VehicleModel> InsertAsync(VehicleModelEntity entity)
        {
            var insert = await Context.AddAsync(entity);
            return Mapper.Map<VehicleModel>(await Context.SaveChangesAsync());
        }

        public async Task UpdateAsync(VehicleModelEntity entity)
        {
            Context.Entry(entity).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
            await Context.SaveChangesAsync();
        }

        #endregion Methods
    }
}
