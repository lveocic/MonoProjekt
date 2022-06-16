using MonoProjekt.Models.Common;

namespace MonoProjekt.Models
{
    public class VehicleMake : IVehicleMake
    {
        #region Properties

        public string Abrv { get; set; }
        public Guid Id { get; set; }
        public string Name { get; set; }

        #endregion Properties
    }
}