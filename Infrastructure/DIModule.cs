using MonoProjekt.Models;
using MonoProjekt.Models.Common;
using MonoProjekt.Repository;
using MonoProjekt.Repository.Common;
using MonoProjekt.Service;
using MonoProjekt.Service.Common;
using Ninject.Modules;

namespace MonoProjekt.Infrastructure
{
    public class DIModule : NinjectModule
    {
        #region Methods

        public override void Load()
        {
            Bind<IVehicleMakeFilter>().To<VehicleMakeFilter>();
            Bind<IVehicleMakeRepository>().To<VehicleMakeRepository>();
            Bind<IVehicleMake>().To<VehicleMake>();
        }

        #endregion Methods
    }
}