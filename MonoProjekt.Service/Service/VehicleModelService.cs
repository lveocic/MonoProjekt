using MonoProjekt.Service.Repository.Common;
using MonoProjekt.Service.Service.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MonoProjekt.Service.Service
{
    public class VehicleModelService : IVehicleModelService
    {
        #region Constructors

        public VehicleModelService(IVehicleModelRepository vehicleModelRepository)
        {
            VehicleModelRepository = vehicleModelRepository;
        }

        #endregion Constructors

        #region Properties

        private IVehicleModelRepository VehicleModelRepository { get; set; }

        #endregion Properties
    }
}
