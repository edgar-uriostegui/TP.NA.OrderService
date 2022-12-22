using Carter;
using MediatR;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Routing;
using OrderService.Application.Querys;
using OrderService.Application.Querys.Models;

namespace OrderService.Application.EndPoints
{
    /// <summary>
    /// Class to represents the GetOrder Endpoint
    /// </summary>
    public class GetOrderEndpoint : ICarterModule
    {
        /// <summary>
        /// Add route for "orderService/GetAll"
        /// </summary>
        /// <param name="app"></param>
        
        public void AddRoutes(IEndpointRouteBuilder app)
        {
            app.MapGet("/v1/orderService/GetAll", (IMediator mediator) =>
            {
                return mediator.Send(new GetOrder.Query());
            })
                .WithName(nameof(GetOrderEndpoint))
                .Produces<List<Order>>();
        }
    }
}
