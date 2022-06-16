namespace MonoProjekt.Models.Common
{
    public interface IVehicleMake
    {
        #region Properties

        string Abrv { get; set; }
        Guid Id { get; set; }
        string Name { get; set; }

        #endregion Properties
    }
}