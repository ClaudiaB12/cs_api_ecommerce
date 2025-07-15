namespace ApiEcommerce.Requests
{
    public class RegisterRequest
    {
        public required string email { get; set; }
        public required string password { get; set; }
        public required string name { get; set; }
        public required string address { get; set; }
        public required string phone { get; set; }

    }
}
