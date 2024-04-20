using AutoMapper;
using Ecommerce.Management.Domain.Models;
using Ecommerce.Management.Domain.Response.User;
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
            CreateMap<GetUserResponseModel, User>().ReverseMap();
            CreateMap<User, GetUserDetailResponseModel>();
        }
    }
}
