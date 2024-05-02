using AutoMapper;
using Ecommerce.Management.Application.Contracts.Exceptions;
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
    public class GetProductCategoryByIdHandler : IRequestHandler<GetproductCategoryByIdRequestModel, GetProductCategoryByIdResponseModel>
    {
        public readonly IProductCategoryRepository _productCategoryRepository;
        public readonly IMapper _mapper;
        public GetProductCategoryByIdHandler(IProductCategoryRepository productCategoryRepository, IMapper mapper)
        {
            _productCategoryRepository = productCategoryRepository;
            _mapper = mapper;
        }

        public async Task<GetProductCategoryByIdResponseModel> Handle(GetproductCategoryByIdRequestModel request, CancellationToken cancellationToken)
        {
            var productCategory = await _productCategoryRepository.GetByIdAsync(request.Id);

            if (productCategory == null)
            {
                throw new NotFoundException(nameof(productCategory), request.Id);
            }

            // Map the retrieved user data to GetUserByIdResponseModel
            var responseModel = _mapper.Map<GetProductCategoryByIdResponseModel>(productCategory);

            return responseModel;
        }
    }
}
