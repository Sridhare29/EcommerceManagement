using AutoMapper;
using Ecommerce.Management.Application.Interfaces;
using Ecommerce.Management.Domain.Request.Queries.Address;
using Ecommerce.Management.Domain.Response.Queries.Address;
using MediatR;

namespace Ecommerce.Management.Application.Handler.Queries.Address
{
    public class GetAddressHandler : IRequestHandler<GetAddressRequestModel, IEnumerable<GetAddressResponseModel>>
    {
        public readonly IAddressRepository _addressRepository;
        public readonly IMapper _mapper;
        public GetAddressHandler(IAddressRepository addressRepository, IMapper mapper)
        {
            _addressRepository = addressRepository;
            _mapper = mapper;
        }
        public async Task<IEnumerable<GetAddressResponseModel>> Handle(GetAddressRequestModel request, CancellationToken cancellationToken)
        {
            var address = await _addressRepository.GetAddressCategoryAsync();
            var results = _mapper.Map <IEnumerable<GetAddressResponseModel>> (address);
            return results;
        }
    }
}
