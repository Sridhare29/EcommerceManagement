using AutoMapper;
using Ecommerce.Management.Application.Interfaces;
using Ecommerce.Management.Domain.Models;
using Ecommerce.Management.Domain.Request.Command.User;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ecommerce.Management.Application.Handler.Command.User
{
    public class PostSiteUserHandler : IRequestHandler<PostUserRequestModel, Guid>
    {
        private readonly IMapper _mapper;
        private readonly IUserRepository _userRepository;

        public PostSiteUserHandler(IMapper mapper, IUserRepository userRepository)
        {
            _mapper = mapper;
            _userRepository = userRepository;
        }
        public async Task<Guid> Handle(PostUserRequestModel request, CancellationToken cancellationToken)
        {
            var user = _mapper.Map<SiteUser>(request);
           
            await _userRepository.createUserAsync(user);
            var response = _mapper.Map<PostUserRequestModel>(request);
            return user.Id;
        }
    }
}
