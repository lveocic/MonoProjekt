using Autofac;
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
    public class DIModule : Module
    {
        #region Methods

        protected override void Load(ContainerBuilder builder)
        {
            builder.RegisterType<VehicleMakeService>().As<IVehicleMakeService>();
            builder.RegisterType<VehicleMakeRepository>().As<IVehicleMakeRepository>();
            builder.RegisterType<VehicleMake>().As<IVehicleMake>();
            builder.RegisterType<VehicleModelService>().As<IVehicleModelService>();
            builder.RegisterType<VehicleModelRepository>().As<IVehicleModelRepository>();
            builder.RegisterType<VehicleModel>().As<IVehicleModel>();
        }

        #endregion Methods
    }
}
