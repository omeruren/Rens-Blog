using RensBlog.Application.Features.Blogs.Endpoints;
using RensBlog.Application.Features.Categories.Endpoints;
using RensBlog.Application.Features.Comments.Endpoints;
using RensBlog.Application.Features.SubComments.Endpoints;
using RensBlog.Application.Features.Users.Endpoints;

namespace RensBlog.API.EndpointRegistration
{
    public static class EndPointRegistrations
    {
        public static void RegisterEndPoints(this IEndpointRouteBuilder app) 
        {
            app.RegisterCategoryEndPoints();
            app.RegisterBlogEndpoints();
            app.RegisterUserEndPoints();
            app.RegisterCommentEndpoints();
            app.RegisterSubCommentEndpoints();
        }
    }
}
