using AutoMapper;
using Ecommerce.Management.Application.Contracts.Exceptions;
using Ecommerce.Management.Application.Interfaces;
using Ecommerce.Management.Domain.Request.Queries.Pickup;
using Ecommerce.Management.Domain.Response.Queries.Address;
using Ecommerce.Management.Domain.Response.Queries.Pickup;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ecommerce.Management.Application.Handler.Queries.Pickup
{
    public class GetPickupRequestByIdHandler : IRequestHandler<GetPickupByIdRequestModel, GetPickupByIdResponseModel>
    {
        public readonly IPickupRepository _pickupRequest;
        public readonly IMapper _mapper;

        public GetPickupRequestByIdHandler(IPickupRepository pickupRequest, IMapper mapper)
        {
            _mapper = mapper;
            _pickupRequest = pickupRequest;
        }

        public async Task<GetPickupByIdResponseModel> Handle(GetPickupByIdRequestModel request, CancellationToken cancellationToken)
        {
            var pickuprequest = await _pickupRequest.GetByIdAsync(request.Id);

            if (pickuprequest == null)
            {
                throw new NotFoundException(nameof(pickuprequest), request.Id);
            }

            var responseModel = _mapper.Map<GetPickupByIdResponseModel>(pickuprequest);

            return responseModel;
        }
    }
}
