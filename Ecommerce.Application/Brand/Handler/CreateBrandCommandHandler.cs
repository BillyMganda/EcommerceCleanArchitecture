using Ecommerce.Application.Brand.Commands;
using Ecommerce.Domain.Entities;
using MediatR;

namespace Ecommerce.Application.Brand.Handler
{
    public class CreateBrandCommandHandler : IRequestHandler<CreateBrandCommand, Brands>
    {
        private readonly IBrandsRepository _repository;
        public CreateBrandCommandHandler(IBrandsRepository repository)
        {
            _repository = repository;
        }

        public async Task<Brands> Handle(CreateBrandCommand request, CancellationToken cancellationToken)
        {
            var brand = new Brands
            {
                brand_name = request.brand_name
            };
            await _repository.CreateBrandAsync(brand);
            return brand;
        }
    }
}
