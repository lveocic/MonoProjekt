using MonoProjekt.Service.Models;
using MonoProjekt.Service.Models.Common;
using MonoProjekt.Service.Repository;
using MonoProjekt.Service.Repository.Common;
using MonoProjekt.Service.Service;
using MonoProjekt.Service.Service.Common;
using Ninject.Modules;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MonoProjekt.Service
{
    internal class DIModule : NinjectModule
    {
        #region Methods

        public override void Load()
        {
            Bind<IVehicleMakeService>().To<VehicleMakeService>();
            Bind<IVehicleMakeRepository>().To<VehicleMakeRepository>();
            Bind<IVehicleMake>().To<VehicleMake>();
            Bind<IVehicleModelService>().To<VehicleModelService>();
            Bind<IVehicleModelRepository>().To<VehicleModelRepository>();
            Bind<IVehicleModel>().To<VehicleModel>();
        }

        #endregion Methods
    }
}