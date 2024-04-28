using AutoMapper;
using Ecommerce.Management.Application.Interfaces;
using Ecommerce.Management.Domain.Models;
using Ecommerce.Management.Domain.Request.Command.Product;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ecommerce.Management.Application.Handler.Command.Product
{
    public class PostProductHandler : IRequestHandler<PostProductRequestModel, Guid>
    {
        public readonly IProductRepository _productRepository;
        public readonly IMapper _mapper;
        public PostProductHandler(IProductRepository productRepository, IMapper mapper)
        {
            _productRepository = productRepository;
            _mapper = mapper;
        }
        public async Task<Guid> Handle(PostProductRequestModel request, CancellationToken cancellationToken)
        {
            var product = _mapper.Map<Domain.Models.Product>(request);

            await _productRepository.createProductAsync(product);
            var response = _mapper.Map<PostProductRequestModel>(request);
            return product.Id;
        }
    }
}
