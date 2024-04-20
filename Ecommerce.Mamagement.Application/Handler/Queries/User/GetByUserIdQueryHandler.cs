using AutoMapper;
using Ecommerce.Management.Application.Contracts.Exceptions;
using Ecommerce.Management.Application.Interface;
using Ecommerce.Management.Domain.Request.Queries.User;
using Ecommerce.Management.Domain.Response.User;
using MediatR;

namespace Ecommerce.Management.Application.Handler.Queries.User
{
    public class GetByUserIdQueryHandler : IRequestHandler<GetUserDetailRequestModel, GetUserDetailResponseModel>
    {
        private readonly IMapper _mapper;
        private readonly IUserRepository _userRepository;
        public GetByUserIdQueryHandler(IMapper mapper, IUserRepository userRepository)
        {
            _mapper = mapper;
            _userRepository = userRepository;
        }
        public async Task<GetUserDetailResponseModel> Handle(GetUserDetailRequestModel request, CancellationToken cancellationToken)
        {
            var users = await _userRepository.GetByIdAsync(request.Id);
            if (users == null)
            {
                throw new NotFoundException(nameof(User), request.Id);
            }

            var results = _mapper.Map<GetUserDetailResponseModel>(users);

            return results;
        }
    }
}
