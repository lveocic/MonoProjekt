using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MonoProjekt.Service.Models.Filters
{
    public class VehicleModelFilter : Filter, IVehicleModelFilter
    {
        #region Properties

        public IEnumerable<Guid> VehicleMakeIds { get; set; }

        #endregion Properties
    }
}
