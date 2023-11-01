using AutoMapper;
using SimpleCommerce.Application.CQRSs.User.CommandCreateUser;
using SimpleCommerce.Application.Helpers;
using SimpleCommerce.Domain.Entities.User;
using TransportGlobal.Application.CQRSs.UserContextCQRSs.CommandUpdateUser;

namespace TransportGlobal.Application.Mappings
{
    public class CommandRequestToEntityMappings : Profile
    {
        public CommandRequestToEntityMappings()
        {
            #region User Bounded Context Mappings
            CreateMap<CreateUserCommandRequest, UserEntity>()
                .ForMember(dest => dest.PasswordHash, opt => opt.MapFrom(src => EncryptionHelper.Encrypt(src.Password)))
                .ConstructUsing(src => new UserEntity(src.Name, src.Surname, src.Email, src.Password));

            CreateMap<UpdateUserCommandRequest, UserEntity>();
            #endregion
        }
    }
}
