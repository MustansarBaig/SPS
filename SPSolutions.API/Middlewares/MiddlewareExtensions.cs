namespace SPSolutions.API.Middlewares
{
    public static class MiddlewareExtensions
    {
        public static IApplicationBuilder UseLogingMiddleware(this IApplicationBuilder builder)
        {
            return builder.UseMiddleware<ExceptionMiddleware>();
        }
    }
}