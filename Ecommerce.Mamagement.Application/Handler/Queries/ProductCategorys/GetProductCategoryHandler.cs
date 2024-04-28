using AutoMapper;
using Ecommerce.Management.Application.Interfaces;
using Ecommerce.Management.Domain.Request.Queries.ProductCategorys;
using Ecommerce.Management.Domain.Response.Queries.Product;
using Ecommerce.Management.Domain.Response.Queries.ProductCategorys;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ecommerce.Management.Application.Handler.Queries.ProductCategorys
{
    public class GetProductCategoryHandler : IRequestHandler<GetproductCategoryRequestModel, IEnumerable<GetProductCategoryResponseModel>>
    {
        public readonly IProductCategoryRepository _productCategoryRepository;
        public readonly IMapper _mapper;
        public GetProductCategoryHandler(IProductCategoryRepository productCategoryRepository, IMapper mapper)
        {
            _productCategoryRepository = productCategoryRepository;
            _mapper = mapper;
        }

        public async Task<IEnumerable<GetProductCategoryResponseModel>> Handle(GetproductCategoryRequestModel request, CancellationToken cancellationToken)
        {
            var productcategory = await _productCategoryRepository.GetProductCategoryAsync();

            var results = _mapper.Map<IEnumerable<GetProductCategoryResponseModel>>(productcategory);

            return results;
        }
    }
}
