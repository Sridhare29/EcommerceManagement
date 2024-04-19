using AutoMapper;
using Ecommerce.Management.Application.Contracts.Exceptions;
using Ecommerce.Management.Application.Contracts.Persistance;
using Ecommerce.Management.Domain.Request.Queries.User;
using MediatR;

namespace Ecommerce.Management.Application.Handler.Queries.User
{
    public class GetByUserIdQueryHandler : IRequestHandler<GetUserDetailQuery, UserDetailsDto>
    {
        private readonly IMapper _mapper;
        private readonly IUserRepository _userRepository;
        public GetByUserIdQueryHandler(IMapper mapper, IUserRepository userRepository)
        {
            _mapper = mapper;
            _userRepository = userRepository;
        }
        public async Task<UserDetailsDto> Handle(GetUserDetailQuery request, CancellationToken cancellationToken)
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
