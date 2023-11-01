using AutoMapper;
using SimpleCommerce.Application.DTOs.Address;
using SimpleCommerce.Application.DTOs.Order;
using SimpleCommerce.Application.DTOs.Product;
using SimpleCommerce.Application.DTOs.User;
using SimpleCommerce.Domain.Entities.Address;
using SimpleCommerce.Domain.Entities.Order;
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

            #region Order Bounded Context Mappings
            CreateMap<OrderEntity, OrderDTO>();

            CreateMap<OrderItemEntity, OrderItemDTO>();

            CreateMap<OrderItemDTOForCreate, OrderItemEntity>()
                .ConstructUsing(src => new OrderItemEntity(0, src.ProductID, src.Quantity));
            #endregion

            #region Address Bounded Context Mappings
            CreateMap<AddressEntity, AddressDTO>();
            #endregion
        }
    }
}
