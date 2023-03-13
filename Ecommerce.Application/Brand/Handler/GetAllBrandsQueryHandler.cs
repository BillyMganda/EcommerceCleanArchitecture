using Ecommerce.Application.Brand.Queries;
using Ecommerce.Domain.Entities;
using MediatR;

namespace Ecommerce.Application.Brand.Handler
{
    public class GetAllBrandsQueryHandler : IRequestHandler<GetAllBrandsQuery, IEnumerable<Brands>>
    {
        private readonly IBrandsRepository _repository;
        public GetAllBrandsQueryHandler(IBrandsRepository repository)
        {
            _repository = repository;
        }

        public async Task<IEnumerable<Brands>> Handle(GetAllBrandsQuery request, CancellationToken cancellationToken)
        {
            return await _repository.GetAllBrandsAsync();
        }
    }
}
