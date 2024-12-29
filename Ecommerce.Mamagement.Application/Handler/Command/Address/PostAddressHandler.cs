using AutoMapper;
using Ecommerce.Management.Application.Interfaces;
using Ecommerce.Management.Domain.Request.Command.Address;
using Ecommerce.Management.Domain.Request.Command.Product;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ecommerce.Management.Application.Handler.Command.Address
{
    public class PostAddressHandler : IRequestHandler<PostAddressRequestModel, Guid>
    {
        public readonly IAddressRepository _addressRepository;
        public readonly IMapper _mapper;

        public PostAddressHandler(IAddressRepository addressRepository, IMapper mapper)
        {
            _addressRepository = addressRepository;
            _mapper = mapper;
        }
        public async Task<Guid> Handle(PostAddressRequestModel request, CancellationToken cancellationToken)
        {
            var postAddress = _mapper.Map<Domain.Models.Address>(request);

            await _addressRepository.CreateAddress(postAddress);
            var response = _mapper.Map<PostAddressRequestModel>(request);
            return postAddress.Id;
        }
    }
}
