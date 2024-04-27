using AutoMapper;
using Ecommerce.Management.Application.Interfaces;
using Ecommerce.Management.Domain.Request.Command.User;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ecommerce.Management.Application.Handler.Command.User
{
    public class DeleteSiteUserHandler : IRequestHandler<DeleteUserRequestModel, string>
    {
        private readonly IMapper _mapper;
        private readonly IUserRepository _userRepository;

        public DeleteSiteUserHandler(IMapper mapper, IUserRepository userRepository)
        {
            _mapper = mapper;
            _userRepository = userRepository;
        }
        public async Task<string> Handle(DeleteUserRequestModel request, CancellationToken cancellationToken)
        {
            await _userRepository.deleteUserAsync(request.Id);
            return "User Id Deleted Successfully!"; 
        }
    }
}
