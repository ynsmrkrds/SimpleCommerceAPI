using AutoMapper;
using SimpleCommerce.Application.DTOs.Product;
using SimpleCommerce.Application.DTOs.User;
using SimpleCommerce.Domain.Entities.Product;
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

            #region Product Bounded Context Mappings
            CreateMap<ProductEntity, ProductDTO>();

            CreateMap<ProductCategoryEntity, ProductCategoryDTO>();
            #endregion
        }
    }
}
