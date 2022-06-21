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

        public async Task DeleteAsync(Guid id)
        {
            var vehicleMaker = Context.VehicleMakers.Find(id);
            Context.VehicleMakers.Remove(vehicleMaker);
            await Context.SaveChangesAsync();
        }

        public async Task<VehicleMake> FindAsync(Guid id)
        {
            return Mapper.Map<VehicleMake>(await Context.VehicleMakers.FindAsync(id));
        }

        public async Task<VehicleMake> InsertAsync(VehicleMakeEntity entity)
        {
            var insert = await Context.AddAsync(entity);
            return Mapper.Map<VehicleMake>(await Context.SaveChangesAsync());
        }

        public async Task UpdateAsync(VehicleMakeEntity entity)
        {
           Context.Entry(entity).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
           await Context.SaveChangesAsync();           
        }

        #endregion Methods
    }
}
