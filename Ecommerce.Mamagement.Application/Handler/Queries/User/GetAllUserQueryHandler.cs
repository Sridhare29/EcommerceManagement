using AutoMapper;
using Ecommerce.Management.Application.Interface;
using Ecommerce.Management.Application.Interfaces.Queries;
using Ecommerce.Management.Domain.Request.Queries.User;
using Ecommerce.Management.Domain.Response.User;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ecommerce.Management.Application.Handler.Queries.User
{
    public class GetAllUserQueryHandler : IRequestHandler<GetUserRequestModel, List<GetUserResponseModel>>
    {
        private readonly IMapper _mapper;
        private readonly IUserQueryRepository _userRepository;
        public GetAllUserQueryHandler(IMapper mapper, IUserQueryRepository userRepository)
        {
            _mapper = mapper;
            _userRepository = userRepository;
        }
        public async Task<List<GetUserResponseModel>> Handle(GetUserRequestModel request, CancellationToken cancellationToken)
        {
            //Query the database
            var users = await _userRepository.GetAllAsync();

            //convert data obj to Dto objs
            var results = _mapper.Map<List<GetUserResponseModel>>(users);

            //return list of Dto obj
            return results;
        }
    }
}
