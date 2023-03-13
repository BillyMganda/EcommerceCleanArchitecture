using MediatR;

namespace Ecommerce.Application.Brand.Commands
{
    public class UpdateBrandCommand : IRequest
    {
        public int brand_id { get; set; }
        public string brand_name { get; set; } = string.Empty;
    }
}
