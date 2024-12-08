using AutoMapper;
using Ecommerce.Management.Application.Interfaces;
using Ecommerce.Management.Domain.Models;
using Ecommerce.Management.Domain.Request.Command.Pickup;
using Ecommerce.Management.Domain.Request.Command.Product;
using Ecommerce.Management.Domain.Response;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ecommerce.Management.Application.Handler.Command.Pickup
{
    public class PickupRequestHandler : IRequestHandler<PickupRequest, Guid>
    {
        private readonly IMapper _mapper;
        private readonly IPickupRequest _pickupRequestRepository;

        public PickupRequestHandler(IMapper mapper, IPickupRequest pickupRequestRepository)
        {
            _mapper = mapper;
            _pickupRequestRepository = pickupRequestRepository;
        }

        public async Task<Guid> Handle(PickupRequest request, CancellationToken cancellationToken)
        {
            // Map PostProductRequestModel to PickupRequest (domain request model)
            var pickupRequest =  _mapper.Map<Domain.Models.Pickup>(request);
            await _pickupRequestRepository.CreatePickupRequest(pickupRequest);
            var response = _mapper.Map<PickupRequest>(request);

            return pickupRequest.Id;
        }
    }
}
