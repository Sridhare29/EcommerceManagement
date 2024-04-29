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
    public class UpdateSiteUserHandler : IRequestHandler<UpdateUserRequestModel, Unit>
    {
        private readonly IMapper _mapper;
        private readonly IUserRepository _userRepository;

        public UpdateSiteUserHandler(IMapper mapper, IUserRepository userRepository)
        {
            _mapper = mapper;
            _userRepository = userRepository;
        }

        async Task<Unit> IRequestHandler<UpdateUserRequestModel, Unit>.Handle(UpdateUserRequestModel request, CancellationToken cancellationToken)
        {
            var existingUser = await _userRepository.GetByIdAsync(request.Id);

            if (existingUser == null)
            {
                throw new Exception("User not found"); 
            }

            var entity = this._mapper.Map<SiteUser>(request);
            await this._userRepository.updateUserAsync( entity);
            return Unit.Value;
        }
    }
}
