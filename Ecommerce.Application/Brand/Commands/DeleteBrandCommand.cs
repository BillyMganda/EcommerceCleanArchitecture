using MediatR;

namespace Ecommerce.Application.Brand.Commands
{
    public class DeleteBrandCommand : IRequest
    {
        public int brand_id { get; set; }
    }
}
