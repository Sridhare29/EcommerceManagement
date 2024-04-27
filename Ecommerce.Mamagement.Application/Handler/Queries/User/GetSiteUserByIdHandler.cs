using AutoMapper;
using Ecommerce.Management.Application.Contracts.Exceptions;
using Ecommerce.Management.Application.Interfaces;
using Ecommerce.Management.Domain.Models;
using Ecommerce.Management.Domain.Request.Queries.User;
using Ecommerce.Management.Domain.Response.Queries.User;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ecommerce.Management.Application.Handler.Queries.User
{
    public class GetSiteUserByIdHandler : IRequestHandler<GetUserByIdRequestModel, GetUserByIdResponseModel>
    {
        private readonly IMapper _mapper;
        private readonly IUserRepository _userRepository;

        public GetSiteUserByIdHandler(IMapper mapper,IUserRepository userRepository)
        {
            _mapper = mapper;
            _userRepository = userRepository;

        }
        public async Task<GetUserByIdResponseModel> Handle(GetUserByIdRequestModel request, CancellationToken cancellationToken)
        {
           
            var user = await _userRepository.GetByIdAsync(request.Id);

            if (user == null)
            {
                throw new NotFoundException(nameof(User), request.Id);
            }

            // Map the retrieved user data to GetUserByIdResponseModel
            var responseModel = _mapper.Map<GetUserByIdResponseModel>(user);

            return responseModel;

        }

    }
}
