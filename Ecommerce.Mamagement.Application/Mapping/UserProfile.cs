using AutoMapper;
using Ecommerce.Management.Domain.Models;
using Ecommerce.Management.Domain.Request.Queries.User;
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
            CreateMap<UserDto, User>().ReverseMap();
            CreateMap<User, UserDetailsDto>();
        }
    }
}
