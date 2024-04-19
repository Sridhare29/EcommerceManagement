using AutoMapper;
using Ecommerce.Mamagement.Application.Contracts.Persistance;
using Ecommerce.Management.Domain.Request.Command.User;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ecommerce.Mamagement.Application.Handler.Command.User.Commands.CreateUser
{
    public class CreateUserCommandHandler : IRequestHandler<CreateUserCommand, Guid>
    {
        private readonly IMapper _mapper;
        private readonly IUserRepository _userRepository;
        public CreateUserCommandHandler(IMapper mapper, IUserRepository userRepository)
        {
            _mapper = mapper;
            _userRepository = userRepository;
        }
        public async Task<Guid> Handle(CreateUserCommand request, CancellationToken cancellationToken)
        {
            //Validate incomming data

            //convert to domain entity
            var usertocreate = _mapper.Map<Management.Domain.Models.User>(request);
            //add to db
            await _userRepository.CreateAsync(usertocreate);
            //return record guid
            return usertocreate.Id;
        }
    }
}
