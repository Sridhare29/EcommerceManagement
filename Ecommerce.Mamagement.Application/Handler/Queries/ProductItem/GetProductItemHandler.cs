using AutoMapper;
using Ecommerce.Management.Application.Interfaces;
using Ecommerce.Management.Domain.Request.Queries.ProductItem;
using Ecommerce.Management.Domain.Response.Queries.Product;
using Ecommerce.Management.Domain.Response.Queries.ProductItem;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ecommerce.Management.Application.Handler.Queries.ProductItem
{
    public class GetProductItemHandler : IRequestHandler<GetProductItemRequestModel, IEnumerable<GetProductItemResponseModel>>
    {
        public readonly IProductItemRepository _productItemRepository;
        public readonly IMapper _mapper;

        public GetProductItemHandler(IProductItemRepository productItemRepository,IMapper mapper)
        {
            _productItemRepository = productItemRepository;
            _mapper = mapper;

        }

        public async Task<IEnumerable<GetProductItemResponseModel>> Handle(GetProductItemRequestModel request, CancellationToken cancellationToken)
        {
            var productItem = await _productItemRepository.GetProductItemAsync();

            var results = _mapper.Map<IEnumerable<GetProductItemResponseModel>>(productItem);

            return results;
        }
    }
}
