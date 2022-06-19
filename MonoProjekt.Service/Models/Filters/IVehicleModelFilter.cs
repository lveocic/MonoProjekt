namespace MonoProjekt.Service.Models.Filters
{
    public interface IVehicleModelFilter
    {
        #region Properties

        IEnumerable<Guid> VehicleMakeIds { get; set; }

        #endregion Properties
    }
}
