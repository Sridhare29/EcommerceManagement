using AutoMapper;
using Ecommerce.Management.Application.Contracts.Exceptions;
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

namespace Ecommerce.Management.Application.Handler.Queries
{
    public class GetProductItemByIdHandler : IRequestHandler<GetProductItemByIdRequestModel, Domain.Response.Queries.ProductItem.GetProductItemByIDResponseModel>
    {
        public readonly IProductItemRepository _productItemRepository;
        public readonly IMapper _mapper;

        public GetProductItemByIdHandler(IProductItemRepository productItemRepository,IMapper mapper)
        {
            _productItemRepository = productItemRepository;
            _mapper = mapper;
        }
        public async Task<GetProductItemByIDResponseModel> Handle(GetProductItemByIdRequestModel request, CancellationToken cancellationToken)
        {
            var user = await _productItemRepository.GetByIdAsync(request.Id);

            if (user == null)
            {
                throw new NotFoundException(nameof(User), request.Id);
            }

            var responseModel = _mapper.Map<GetProductItemByIDResponseModel>(user);

            return responseModel;
        }
    }
}
