using AutoMapper;
using Ecommerce.Mamagement.Application.Contracts.Exceptions;
using Ecommerce.Mamagement.Application.Contracts.Persistance;
using Ecommerce.Mamagement.Application.Features.User;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ecommerce.Mamagement.Application.Features.User.GetAllUser.Commands.DeleteUser
{
    public class DeleteUserCommandHandler : IRequestHandler<DeleteUserCommand, Unit>
    {
        private readonly IUserRepository _userRepository;
        public DeleteUserCommandHandler( IUserRepository userRepository)
        {
            _userRepository = userRepository;
        }
        public async Task<Unit> Handle(DeleteUserCommand request, CancellationToken cancellationToken)
        {
            var userToDelete = await _userRepository.GetByIdAsync(request.Id);
            //verify the record already exsist
            if (userToDelete == null)
            {
                throw new NotFoundException(nameof(User), request.Id);
            }
            
            //remove form db
            await _userRepository.DeleteAsync(userToDelete);
            //return record id
            return Unit.Value;
        }
    }
}
