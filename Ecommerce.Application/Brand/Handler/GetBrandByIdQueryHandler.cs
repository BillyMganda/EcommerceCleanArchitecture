using Ecommerce.Application.Brand.Queries;
using Ecommerce.Domain.Entities;
using MediatR;

namespace Ecommerce.Application.Brand.Handler
{
    public class GetBrandByIdQueryHandler : IRequestHandler<GetBrandByIdQuery, Brands>
    {
        private readonly IBrandsRepository _repository;
        public GetBrandByIdQueryHandler(IBrandsRepository repository)
        {
            _repository = repository;
        }

        public async Task<Brands> Handle(GetBrandByIdQuery request, CancellationToken cancellationToken)
        {
            return await _repository.GetBrandByIdAsync(request.brand_id);
        }
    }
}
