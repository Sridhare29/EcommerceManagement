using AutoMapper;
using Ecommerce.Management.Application.Contracts.Persistance;
using Ecommerce.Management.Domain.Request.Command.User;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ecommerce.Management.Application.Handler.Command.User
{
    public class UpdateUserCommandHandler : IRequestHandler<UpdateUserCommand, Unit>
    {
        private readonly IMapper _mapper;
        private readonly IUserRepository _userRepository;
        public UpdateUserCommandHandler(IMapper mapper, IUserRepository userRepository)
        {
            _mapper = mapper;
            _userRepository = userRepository;
        }
        public async Task<Unit> Handle(UpdateUserCommand request, CancellationToken cancellationToken)
        {
            //Validate incomming data

            //convert to domain entity
            var usertoupdate = _mapper.Map<Management.Domain.Models.User>(request);
            //add to db
            await _userRepository.UpdateAsync(usertoupdate);
            //return unit value
            return Unit.Value;
        }
    }
}
