using AutoMapper;
using MonoProjekt.Service.DAL;
using MonoProjekt.Service.Models;
using MonoProjekt.Service.Models.Common;
using MonoProjekt.Service.Repository.Common;

namespace MonoProjekt.Service.Repository
{
    public class VehicleMakeRepository : IVehicleMakeRepository
    {
        #region Fields

        private MonoProjektContext Context;

        #endregion Fields

        #region Constructors

        public VehicleMakeRepository(MonoProjektContext context, IMapper mapper)
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
            var vehicleMaker = Context.VehicleMakers.Find(id);
            if (vehicleMaker == null)
                return false;
            Context.VehicleMakers.Remove(vehicleMaker);
            await Context.SaveChangesAsync();
            return true;
        }

        public async Task<VehicleMake> FindAsync(Guid id)
        {
            return Mapper.Map<VehicleMake>(await Context.VehicleMakers.FindAsync(id));
        }

        public async Task<bool> InsertAsync(VehicleMakeEntity entity)
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

        public async Task<bool> UpdateAsync(VehicleMakeEntity entity)
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
