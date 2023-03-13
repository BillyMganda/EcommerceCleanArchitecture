using Ecommerce.Application.Brand.Commands;
using MediatR;

namespace Ecommerce.Application.Brand.Handler
{
    public class DeleteBrandCommandHandler : IRequestHandler<DeleteBrandCommand>
    {
        private readonly IBrandsRepository _repository;
        public DeleteBrandCommandHandler(IBrandsRepository repository)
        {
            _repository = repository;
        }

        public async Task Handle(DeleteBrandCommand request, CancellationToken cancellationToken)
        {
            var brand = await _repository.GetBrandByIdAsync(request.brand_id);
            if (brand == null)
            {
                //throw new NotFoundException(nameof(Brand), request.Id);
            }
            await _repository.DeleteBrandAsync(request.brand_id);
        }
    }
}
