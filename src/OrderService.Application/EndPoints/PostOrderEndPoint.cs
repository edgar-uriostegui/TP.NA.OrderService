using Carter;
using MediatR;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Routing;
using OrderService.Application.Commands;
using OrderService.Application.Commands.Request;

namespace OrderService.Application.EndPoints
{
    /// <summary>
    /// Class to represents the PostOrder Endpoint
    /// </summary>
    public class PostOrderEndPoint : ICarterModule
    {
        /// <summary>
        /// Add route for "orderService/create"
        /// </summary>
        /// <param name="app"></param>

        public void AddRoutes(IEndpointRouteBuilder app)
        {
            app.MapPost("/api/v1/orderService/create", ([FromBody] PostOrderRequest order, IMediator mediator) =>
            {
                return mediator.Send(new PostCreateOrder.Command(order));
            })
            .WithName(nameof(PostOrderEndPoint));
        }
    }
}
