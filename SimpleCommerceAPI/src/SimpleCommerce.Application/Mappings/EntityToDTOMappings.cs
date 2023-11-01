using AutoMapper;
using SimpleCommerce.Application.DTOs.User;
using SimpleCommerce.Domain.Entities.User;

namespace EventManagement.Application.Mappings
{
    public class EntityToDTOMappings : Profile
    {
        public EntityToDTOMappings()
        {
            #region User Bounded Context Mappings
            CreateMap<UserEntity, UserDTO>();
            #endregion
        }
    }
}
