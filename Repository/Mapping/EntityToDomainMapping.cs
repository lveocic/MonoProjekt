using AutoMapper;
using MonoProjekt.DAL;
using MonoProjekt.Models;
using MonoProjekt.Models.Common;

namespace MonoProjekt.Repository.Mapping
{
    public class EntityToDomainMapping : Profile
    {
        #region Constructors

        public EntityToDomainMapping()
        {
            CreateMap<VehicleMake, VehicleMakeEntity>().ReverseMap();
            CreateMap<IVehicleMake, VehicleMakeEntity>().ReverseMap();
        }

        #endregion Constructors
    }
}