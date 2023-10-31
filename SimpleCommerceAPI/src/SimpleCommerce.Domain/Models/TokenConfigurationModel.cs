namespace SimpleCommerce.Domain.Models
{
    public class TokenConfigurationModel
    {
        public string Issuer { get; set; }

        public string Audience { get; set; }

        public int DurationInMinutes { get; set; }

        public string Key { get; set; }

        public TokenConfigurationModel(string issuer, string audience, int durationInMinutes, string key)
        {
            Issuer = issuer;
            Audience = audience;
            DurationInMinutes = durationInMinutes;
            Key = key;
        }
    }
}
