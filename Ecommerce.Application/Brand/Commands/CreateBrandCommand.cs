using Ecommerce.Domain.Entities;
using MediatR;

namespace Ecommerce.Application.Brand.Commands
{
    public class CreateBrandCommand : IRequest<Brands>
    {
        public string brand_name { get; set; } = string.Empty;
    }
}
