using AutoMapper;
using Ecommerce.Mamagement.Application.Contracts.Exceptions;
using Ecommerce.Mamagement.Application.Contracts.Persistance;
using Ecommerce.Mamagement.Application.Features.User.GetAllUser.Queries.GetAllUser;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ecommerce.Mamagement.Application.Features.User.GetAllUser.Queries.GetByUserId
{
    public class GetByUserIdQueryHandler : IRequestHandler<GetByUserIdQuery, UserDetailsDto>
    {
        private readonly IMapper _mapper;
        private readonly IUserRepository _userRepository;
        public GetByUserIdQueryHandler  (IMapper mapper, IUserRepository userRepository)
        {
            _mapper = mapper;
            _userRepository = userRepository;
        }
        public async Task<UserDetailsDto> Handle(GetByUserIdQuery request, CancellationToken cancellationToken)
        {
            var users = await _userRepository.GetByIdAsync(request.Id);
            if (users == null)
            {
                throw new NotFoundException(nameof(User), request.Id);
            }

            var results = _mapper.Map<UserDetailsDto>(users);

            return results;
        }
    }
}
