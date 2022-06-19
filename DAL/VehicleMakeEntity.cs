namespace MonoProjekt.Service.DAL
{
    public class VehicleMakeEntity
    {
        #region Properties

        public string Abrv { get; set; }
        public Guid Id { get; set; }
        public string Name { get; set; }
        public List<VehicleModelEntity> VehicleModels { get; set; }

        #endregion Properties
    }
}