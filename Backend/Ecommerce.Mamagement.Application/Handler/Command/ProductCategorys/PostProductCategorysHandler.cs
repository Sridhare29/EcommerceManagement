using AutoMapper;
using Ecommerce.Management.Application.Interfaces;
using Ecommerce.Management.Domain.Models;
using Ecommerce.Management.Domain.Request.Command.ProductCategorys;
using Ecommerce.Management.Domain.Request.Command.User;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ecommerce.Management.Application.Handler.Command.ProductCategorys
{
    public class PostProductCategorysHandler : IRequestHandler<PostProductCategoryRequestModel, Guid>
    {
        public readonly IProductCategoryRepository _productCategoryRepository;
        public readonly IMapper _mapper;
        public PostProductCategorysHandler(IProductCategoryRepository productCategoryRepository, IMapper mapper)
        {
            _productCategoryRepository = productCategoryRepository;
            _mapper = mapper;
        }

        public async Task<Guid> Handle(PostProductCategoryRequestModel request, CancellationToken cancellationToken)
        {
            var productCategory = _mapper.Map<ProductCategory>(request);

            try
            {
                await _productCategoryRepository.createProductCategoryAsync(productCategory);
                return productCategory.Id;
            }
            catch (Exception ex)
            {
                // Handle the exception, e.g., log it or throw a custom exception
                throw new Exception("Error occurred while creating product category.", ex);
            }
        }

    }
}
