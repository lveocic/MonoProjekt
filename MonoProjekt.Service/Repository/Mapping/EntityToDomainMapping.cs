using AutoMapper;
using MonoProjekt.Service.DAL;
using MonoProjekt.Service.Models;
using MonoProjekt.Service.Models.Common;

namespace MonoProjekt.Service.Repository.Mapping
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