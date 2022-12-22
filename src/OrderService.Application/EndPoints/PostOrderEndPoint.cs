using Carter;
using MediatR;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Routing;
using OrderService.Application.Commands;
using OrderService.Application.Commands.Models;

using OrderService.Domain.Models;
using OrderService.Repository.Repository.Core;

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
            app.MapPost("/v1/orderService/create", ([FromBody] Order order, IMediator mediator) =>
            {
                return mediator.Send(new PostCreateOrder.Command(order));
            })
            .WithName(nameof(PostOrderEndPoint));
        }
    }
}
