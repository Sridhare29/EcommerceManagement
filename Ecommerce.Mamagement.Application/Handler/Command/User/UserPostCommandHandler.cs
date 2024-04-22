using AutoMapper;
using Ecommerce.Management.Application.Contracts.Exceptions;
using Ecommerce.Management.Application.Interface;
using Ecommerce.Management.Application.Interfaces.Queries;
using Ecommerce.Management.Domain.Request.Command.User;
using FluentValidation;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ecommerce.Management.Application.Handler.Command.User
{
    public class UserPostCommandHandler : IRequestHandler<CreateUserCommand, Guid>
    {
        private readonly IMapper _mapper;
        private readonly IUserQueryRepository _userRepository;
        public UserPostCommandHandler(IMapper mapper, IUserQueryRepository userRepository)
        {
            _mapper = mapper;
            _userRepository = userRepository;
        }
        public async Task<Guid> Handle(CreateUserCommand request, CancellationToken cancellationToken)
        {
            var validator = new UserPostValidator(_userRepository);
            var validationResult = await validator.ValidateAsync(request);

            if (validationResult.Errors.Any())
                throw new BadRequestException("Invalid User", validationResult);

            var usertocreate = _mapper.Map<Management.Domain.Models.User>(request);

            await _userRepository.CreateAsync(usertocreate);

            return usertocreate.Id;
        }
    }
}
