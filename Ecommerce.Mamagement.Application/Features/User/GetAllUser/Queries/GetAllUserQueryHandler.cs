using AutoMapper;
using Ecommerce.Mamagement.Application.Persistance;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ecommerce.Mamagement.Application.Features.User.GetAllUser.Queries
{
    public class GetAllUserQueryHandler : IRequestHandler<GetAllUserQuery, List<UserDto>>
    {
        private readonly IMapper _mapper;
        private readonly IUserRepository _userRepository;
        public GetAllUserQueryHandler(IMapper mapper, IUserRepository userRepository)
        {
            this._mapper = mapper;
            this._userRepository = userRepository;
        }
        public async Task<List<UserDto>> Handle(GetAllUserQuery request, CancellationToken cancellationToken)
        {
            //Query the database
            var users = await _userRepository.GetAllAsync();

           //convert data obj to Dto objs
           var results = _mapper.Map<List<UserDto>>(users);

           //return list of Dto obj
           return results;
        }
    }
}
