using AutoMapper;
using Ecommerce.Management.Application.Contracts.Exceptions;
using Ecommerce.Management.Application.Interfaces;
using Ecommerce.Management.Domain.Request.Queries.Address;
using Ecommerce.Management.Domain.Response.Queries.Address;
using Ecommerce.Management.Domain.Response.Queries.ProductCategorys;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ecommerce.Management.Application.Handler.Queries.Address
{
    public class GetAddressHandlerById : IRequestHandler<GetAddressByIdRequestModel, GetAddressByIdResponseModel>
    {
        public readonly IAddressRepository _addressRepository;
        public readonly IMapper _mapper;

        public GetAddressHandlerById(IAddressRepository addressRepository,IMapper mapper)
        {
            _addressRepository = addressRepository;
            _mapper = mapper;
        }

        public async Task<GetAddressByIdResponseModel> Handle(GetAddressByIdRequestModel request, CancellationToken cancellationToken)
        {
            var userAddress = await _addressRepository.GetByIdAsync(request.Id);

            if (userAddress == null)
            {
                throw new NotFoundException(nameof(userAddress), request.Id);
            }

            var responseModel = _mapper.Map<GetAddressByIdResponseModel>(userAddress);

            return responseModel;
        }
    }
}
