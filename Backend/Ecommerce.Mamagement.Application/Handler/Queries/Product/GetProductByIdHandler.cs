using AutoMapper;
using Ecommerce.Management.Application.Contracts.Exceptions;
using Ecommerce.Management.Application.Interfaces;
using Ecommerce.Management.Domain.Request.Queries.Product;
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
    public class GetProductByIdHandler : IRequestHandler<GetProductByIdRequestModel, GetProductByIDResponseModel>
    {
        public readonly IProductRepository _productRepository;
        public readonly IMapper _mapper;
        public GetProductByIdHandler(IProductRepository productRepository, IMapper mapper)
        {
            _productRepository = productRepository;
            _mapper = mapper;
        }

        public async Task<GetProductByIDResponseModel> Handle(GetProductByIdRequestModel request, CancellationToken cancellationToken)
        {
            var user = await _productRepository.GetByIdAsync(request.Id);

            if (user == null)
            {
                throw new NotFoundException(nameof(User), request.Id);
            }

            // Map the retrieved user data to GetUserByIdResponseModel
            var responseModel = _mapper.Map<GetProductByIDResponseModel>(user);

            return responseModel;
        }
    }
}
