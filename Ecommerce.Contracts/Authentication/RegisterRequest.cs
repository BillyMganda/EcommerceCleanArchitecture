namespace Ecommerce.Contracts.Authentication
{
    public class RegisterRequest
    {
        public string email { get; set; } = string.Empty;
        public string password { get; set; } = string.Empty;
    }
}
