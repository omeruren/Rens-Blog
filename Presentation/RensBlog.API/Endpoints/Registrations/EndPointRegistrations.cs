namespace RensBlog.API.Endpoints.Registrations
{
    public static class EndPointRegistrations
    {
        public static void RegisterEndPoints(this IEndpointRouteBuilder app) 
        {
            app.RegisterCategoryEndPoints();
        }
    }
}
