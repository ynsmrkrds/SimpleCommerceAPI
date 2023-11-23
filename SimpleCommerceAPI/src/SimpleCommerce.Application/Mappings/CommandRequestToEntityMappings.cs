using AutoMapper;
using SimpleCommerce.Application.CQRSs.Address.CommandCreateAddress;
using SimpleCommerce.Application.CQRSs.User.CommandCreateUser;
using SimpleCommerce.Domain.Entities.Address;
using SimpleCommerce.Domain.Entities.User;
using TransportGlobal.Application.CQRSs.UserContextCQRSs.CommandUpdateUser;

namespace TransportGlobal.Application.Mappings
{
    public class CommandRequestToEntityMappings : Profile
    {
        public CommandRequestToEntityMappings()
        {
            #region User Bounded Context Mappings
            CreateMap<CreateUserCommandRequest, UserEntity>();

            CreateMap<UpdateUserCommandRequest, UserEntity>();
            #endregion

            #region Address Bounded Context Mappings
            CreateMap<CreateAddressCommandRequest, AddressEntity>()
                .ConstructUsing(src => new AddressEntity(Guid.NewGuid().ToString(), src.Title, src.City, src.District, src.Street, src.Address));

            CreateMap<UpdateUserCommandRequest, UserEntity>();
            #endregion
        }
    }
}
