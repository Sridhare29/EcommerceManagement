using AutoMapper;
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
    public class GetPickupDetailsHandler : IRequestHandler<GetPickupRequestModel, IEnumerable<GetPickupResponseModel>>
    {
        public readonly IPickupRepository _pickupRepository;
        public readonly IMapper _mapper;

        public GetPickupDetailsHandler(IPickupRepository pickupRepository, IMapper mapper)
        {
            _pickupRepository = pickupRepository;
            _mapper = mapper;
        }

        public async Task<IEnumerable<GetPickupResponseModel>> Handle(GetPickupRequestModel request, CancellationToken cancellationToken)
        {
            var pickuprepo = await _pickupRepository.GetPickupAsync();
            var results = _mapper.Map<IEnumerable<GetPickupResponseModel>>(pickuprepo);
            return results;
        }
    }
}
