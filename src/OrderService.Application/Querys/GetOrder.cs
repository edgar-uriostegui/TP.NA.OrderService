using AutoMapper;
using MediatR;
using OrderService.Application.Querys.Models;
using OrderService.Application.Querys.Request;
using OrderService.Application.Querys.Response;
using OrderService.Application.Utils;
using OrderService.Domain.Models;
using OrderService.Repository.Repository.Persistance;
using System.Net;

namespace OrderService.Application.Querys
{
    /// <summary>
    /// Query to retieve all Orders
    /// </summary>
    public class GetOrder
    {
        #region Query
        /// <summary>
        /// QueryRequest GetProduct
        /// </summary>
        
        public class Query : IRequest<Response<Result>>
        {
            /// <summary>
            /// GetOrdertRequest field
            /// </summary>
            public GetOrderRequest? Request { get; set; }
        }
        #endregion

        #region Result
        /// <summary>
        /// Result GetOrder
        /// </summary>
        public class Result
        {
            /// <summary>
            /// GetOrderResponse field
            /// </summary>
            public GetOrderResponse GetOrderResponse { get; set; }
            /// <summary>
            /// Ctor Result
            /// </summary>
            public Result()
            {
                GetOrderResponse = new GetOrderResponse();
            }
        }
        #endregion 

        #region Handler
        /// <summary>
        /// Handler GetOrder
        /// </summary>
        public class Handler : IRequestHandler<Query, Response<Result>>
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
            public async Task<Response<Result>> Handle(Query request, CancellationToken cancellationToken)
            {
                try
                {
                    _response.Payload.GetOrderResponse.Orders = _mapper.Map<List<OrderEntity>, List<Order>>(_repository.GetAllOrders());
                }
                catch (Exception ex)
                {
                    _response.SetFailureResponse(string.Empty, $"An error was throw trying to get all the orders");
                    _response.Payload.GetOrderResponse.StatusCode = (int)HttpStatusCode.InternalServerError;
                    throw;
                }

                return _response;
            }
        }
        #endregion

        #region Mapper
        /// <summary>
        /// Mapping profile for GetOrder
        /// </summary>
        public class Mapping : Profile
        {
            /// <summary>
            /// Ctor that initialize all mappings for GetOrder
            /// </summary>
            public Mapping() => CreateMap<OrderEntity, Order>();
        }
        #endregion
    }
}
