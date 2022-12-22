using AutoMapper;
using MediatR;
using OrderService.Application.Commands.Response;
using OrderService.Application.Commands.Models;
using OrderService.Application.Utils;
using OrderService.Domain.Models;
using OrderService.Repository.Repository.Persistance;
using System.Net;

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
            public Order Order { get; set; }
            /// <summary>
            /// Constructor Comand
            /// </summary>
            public Command(Order order)
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
                    //List<ProductEntity> products = (List<ProductEntity>)request.Order.Products.Select(p => new ProductEntity { Id = p.Id, Name = p.Name, Price = p.Price, Quantity = p.Quantity });

                    //_response.Payload.PostOrderResponse.Orders = _mapper.Map<OrderEntity, Order>(
                    //    _repository.CreateOrder(request.Order.Description, (List<ProductEntity>)products, request.Order.OrderDate));

                    _response.Payload.PostOrderResponse.Orders = _mapper.Map<OrderEntity, Order>(
                        _repository.CreateOrder(request.Order.Description, request.Order.ProductId, request.Order.OrderDate));


                    //_response.Payload.PostOrderResponse.Orders = _mapper.Map<List<OrderEntity>, List<Order>>(_repository.PostOrderId(request.Order.Id));
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
