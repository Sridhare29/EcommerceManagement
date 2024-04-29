using AutoMapper;
using Ecommerce.Management.Application.Interfaces;
using Ecommerce.Management.Domain.Request.Queries;
using Ecommerce.Management.Domain.Response.Queries.Product;
using Ecommerce.Management.Domain.Response.Queries.User;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ecommerce.Management.Application.Handler.Queries.Product
{
    public class GetProductHandler : IRequestHandler<GetProductRequestModel, IEnumerable<GetProductResponseModel>>
    {
        public readonly IProductRepository _productRepository;
        public readonly IMapper _mapper;
        public GetProductHandler(IProductRepository productRepository, IMapper mapper)
        {
            _productRepository = productRepository;
            _mapper = mapper;
        }

        public async Task<IEnumerable<GetProductResponseModel>> Handle(GetProductRequestModel request, CancellationToken cancellationToken)
        {
            var users = await _productRepository.GetProductAsync();

            var results = _mapper.Map<IEnumerable<GetProductResponseModel>>(users);

            return results;
        }
    }
}
