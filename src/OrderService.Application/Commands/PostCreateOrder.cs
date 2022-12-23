using AutoMapper;
using MediatR;
using OrderService.Application.Commands.Response;
using OrderService.Application.Commands.Models;
using OrderService.Application.Utils;
using OrderService.Domain.Models;
using OrderService.Repository.Repository.Persistance;
using System.Net;
using OrderService.Application.Commands.Request;

namespace OrderService.Application.Commands
{
    /// <summary>
    /// Query to retieve all Orders
    /// </summary>
    public class PostCreateOrder
    {
        #region Command
        /// <summary>
        /// Command Request PostOrder
        /// </summary>

        public class Command : IRequest<Response<Result>>
        {
            /// <summary>
            /// PostOrdertRequest field
            /// </summary>
            public PostOrderRequest Order { get; }
            /// <summary>
            /// Constructor Comand
            /// </summary>
            public Command(PostOrderRequest order)
            {
                 Order = order;
            }
        }
        #endregion

        #region Result
        /// <summary>
        /// Result PostOrder
        /// </summary>
        public class Result
        {
            /// <summary>
            /// PostOrderResponse field
            /// </summary>
            public PostOrderResponse PostOrderResponse { get; set; }
            /// <summary>
            /// Ctor Result
            /// </summary>
            public Result()
            {
                PostOrderResponse = new PostOrderResponse();
            }
        }
        #endregion 

        #region Handler
        /// <summary>
        /// Handler PostOrder
        /// </summary>
        public class Handler : IRequestHandler<Command, Response<Result>>
        {
            private readonly IMapper _mapper;
            private readonly IOrderRepository _repository;
            private readonly Response<Result> _response;
            /// <summary>
            /// Ctor Handler
            /// </summary>
            /// <param name="mapper"></param>
            /// <param name="repository"></param>
            public Handler(IMapper mapper, IOrderRepository repository)
            {
                _mapper = mapper;
                _repository = repository;
                _response = new Response<Result>
                {
                    Payload = new Result()
                };
            }
            /// <summary>
            /// Handle method that executes the logic to retrieve all orders
            /// </summary>
            /// <param name="request"></param>
            /// <param name="cancellationToken"></param>
            /// <returns></returns>
            public async Task<Response<Result>> Handle(Command request, CancellationToken cancellationToken)
            {
                try
                {
                    _response.Payload.PostOrderResponse.OrderId = _repository.CreateOrder(request.Order.Description, request.Order.Products, request.Order.OrderDate);
                }
                catch (Exception ex)
                {
                    _response.SetFailureResponse(string.Empty, $"An error was throw trying to post order id");
                    _response.Payload.PostOrderResponse.StatusCode = (int)HttpStatusCode.InternalServerError;
                    throw;
                }

                return _response;
            }
        }
        #endregion
    }
}
