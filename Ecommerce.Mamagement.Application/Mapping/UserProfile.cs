using AutoMapper;
using Ecommerce.Management.Domain.Models;
using Ecommerce.Management.Domain.Request.Command.Pickup;
using Ecommerce.Management.Domain.Request.Command.Product;
using Ecommerce.Management.Domain.Request.Command.ProductCategorys;
using Ecommerce.Management.Domain.Request.Command.ProductItem;
using Ecommerce.Management.Domain.Request.Command.User;
using Ecommerce.Management.Domain.Request.Queries.User;
using Ecommerce.Management.Domain.Response;
using Ecommerce.Management.Domain.Response.Queries.Product;
using Ecommerce.Management.Domain.Response.Queries.ProductCategorys;
using Ecommerce.Management.Domain.Response.Queries.ProductItem;
using Ecommerce.Management.Domain.Response.Queries.User;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ecommerce.Management.Application.Mapping
{
    public class UserProfile : Profile
    {
        public UserProfile()
        {
            CreateMap<GetUserResponseModel, SiteUser>().ReverseMap();

            CreateMap<SiteUser, GetUserByIdResponseModel>().ReverseMap();

            CreateMap<PostUserRequestModel, SiteUser>().ReverseMap();

            CreateMap<UpdateUserRequestModel, SiteUser>().ReverseMap();


            //product

            CreateMap<GetProductResponseModel, Product>().ReverseMap();

            CreateMap<Product, GetProductByIDResponseModel>().ReverseMap();

            CreateMap<PostProductRequestModel, Product>().ReverseMap();

            //productcategory
            CreateMap<ProductCategory, GetProductCategoryByIdResponseModel>().ReverseMap();

            CreateMap<PostProductCategoryRequestModel, ProductCategory>().ReverseMap();

            CreateMap<GetProductCategoryResponseModel, ProductCategory>().ReverseMap();

            //productitem
            CreateMap<ProductItem, GetProductItemByIDResponseModel>().ReverseMap();

            CreateMap<PostProductItemRequestModel, ProductItem>().ReverseMap();

            CreateMap<GetProductItemResponseModel, ProductItem>().ReverseMap();

            CreateMap<PickupRequest, Pickup>().ReverseMap();

        }
    }
}
