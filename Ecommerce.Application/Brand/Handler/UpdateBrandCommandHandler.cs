using Ecommerce.Application.Brand.Commands;
using MediatR;

namespace Ecommerce.Application.Brand.Handler
{
    public class UpdateBrandCommandHandler : IRequestHandler<UpdateBrandCommand>
    {
        private readonly IBrandsRepository _repository;
        public UpdateBrandCommandHandler(IBrandsRepository repository)
        {
            _repository = repository;
        }

        public async Task Handle(UpdateBrandCommand request, CancellationToken cancellationToken)
        {
            var brand = await _repository.GetBrandByIdAsync(request.brand_id);
            if (brand == null)
            {
                //throw new NotFoundException(nameof(Brand), request.brand_id);
            }
            brand!.brand_name = request.brand_name;
            await _repository.UpdateBrandAsync(brand);            
        }
    }
}
