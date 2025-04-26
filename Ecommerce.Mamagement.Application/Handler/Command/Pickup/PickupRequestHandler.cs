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
    public class PickupRequestHandler : IRequestHandler<PostPickupRequestModel, Guid>
    {
        private readonly IMapper _mapper;
        private readonly IPickupRepository _pickupRequestRepository;
        private readonly IAddressRepository _addressRepository;

        public PickupRequestHandler(
            IMapper mapper,
            IPickupRepository pickupRequestRepository,
            IAddressRepository addressRepository) 
        {
            _mapper = mapper;
            _pickupRequestRepository = pickupRequestRepository;
            _addressRepository = addressRepository;
        }

        public async Task<Guid> Handle(PostPickupRequestModel request, CancellationToken cancellationToken)
        {
            var pickupRequest = _mapper.Map<Domain.Models.Pickup>(request);

            var address = await _addressRepository.GetAddressCategoryAsync();

            if (address == null)
            {
                throw new Exception("No address found for the current user.");
            }

            pickupRequest.AddressId = address.FirstOrDefault().Id;

            await _pickupRequestRepository.CreatePickupRequest(pickupRequest);

            return pickupRequest.Id;
        }
    }
}
