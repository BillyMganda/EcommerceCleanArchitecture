using Ecommerce.Domain.Entities;
using MediatR;

namespace Ecommerce.Application.Brand.Queries
{
    public class GetBrandByIdQuery : IRequest<Brands>
    {
        public int brand_id { get; set; }
    }
}
