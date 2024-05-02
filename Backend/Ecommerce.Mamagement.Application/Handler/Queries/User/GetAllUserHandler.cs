using AutoMapper;
using Ecommerce.Management.Application.Interfaces;
using Ecommerce.Management.Domain.Request.Queries.User;
using Ecommerce.Management.Domain.Response.Queries.User;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ecommerce.Management.Application.Handler.Queries.User
{
    public class GetAllUserHandler : IRequestHandler<GetUserRequestModel, IEnumerable<GetUserResponseModel>>
    {
        private readonly IMapper _mapper;
        private readonly IUserRepository _userRepository;
        public GetAllUserHandler(IMapper mapper, IUserRepository userRepository)
        {
            _mapper = mapper;
            _userRepository = userRepository;
        }

        public async Task<IEnumerable<GetUserResponseModel>> Handle(GetUserRequestModel request, CancellationToken cancellationToken)
        {
            var users = await _userRepository.GetUsersAsync();

            //convert data obj to Dto objs
            var results = _mapper.Map<IEnumerable<GetUserResponseModel>>(users);

            //return list of Dto obj
            return results;
        }
    }
}
