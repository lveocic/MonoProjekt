using MonoProjekt.Service.Models.Common;

namespace MonoProjekt.Service.Models
{
    public class VehicleMake : IVehicleMake
    {
        #region Properties

        public string Abrv { get; set; }
        public Guid Id { get; set; }
        public string Name { get; set; }
        public IEnumerable<IVehicleModel> VehicleModels { get; set; }

        #endregion Properties
    }
}