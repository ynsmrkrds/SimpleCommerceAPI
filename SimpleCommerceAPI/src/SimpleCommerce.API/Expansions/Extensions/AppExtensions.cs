using SimpleCommerce.API.Expansions.Handlers;

namespace SimpleCommerce.API.Expansions.Extensions
{
    public static class AppExtensions
    {
        public static WebApplication AddAPILayer(this WebApplication app)
        {
            // Dictate to use custom exception handler
            app.UseCustomException();

            app.UseCors("AllowAll");

            return app;
        }
    }
}
