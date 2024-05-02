using AutoMapper;
using Ecommerce.Management.Application.Interfaces;
using Ecommerce.Management.Domain.Request.Command.Product;
using Ecommerce.Management.Domain.Request.Command.ProductItem;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ecommerce.Management.Application.Handler.Command.ProductItem
{
    public class PostProductItemHandler : IRequestHandler<PostProductItemRequestModel, Guid>
    {
        public readonly IProductItemRepository _productItemRepository;
        public readonly IMapper _mapper;
        public PostProductItemHandler(IProductItemRepository productItemRepository, IMapper mapper)
        {
            _productItemRepository = productItemRepository;
            _mapper = mapper;
        }
        public async Task<Guid> Handle(PostProductItemRequestModel request, CancellationToken cancellationToken)
        {
            var product = _mapper.Map<Domain.Models.ProductItem>(request);

            await _productItemRepository.createProductItemAsync(product);
            var response = _mapper.Map<PostProductItemRequestModel>(request);
            return product.Id;
        }
    }
}
