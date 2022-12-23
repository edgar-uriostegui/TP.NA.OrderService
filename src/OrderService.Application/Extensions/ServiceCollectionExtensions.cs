﻿using MediatR;
using Microsoft.Extensions.DependencyInjection;
using OrderService.Repository.Repository.Core;
using OrderService.Repository.Repository.Persistance;
using System.Reflection;

namespace OrderService.Application.Extensions
{
    /// <summary>
    /// Class to configure service collection
    /// </summary>
    public static class ServiceCollectionExtensions
    {
        /// <summary>
        /// Method to configure Madiatr
        /// </summary>
        /// <param name="services"></param>
        /// <returns></returns>
        public static IServiceCollection ConfigMediator(this IServiceCollection services)
        {
            services.AddMediatR(typeof(ServiceCollectionExtensions).GetTypeInfo().Assembly);

            services.AddTransient<IOrderRepository, OrderRepository>();

            return services;
        }

        /// <summary>
        /// Method to configure AutoMapper
        /// </summary>
        /// <param name="builder"></param>
        public static void ConfigAutoMapper(this IServiceCollection builder)
        {
            builder.AddAutoMapper(typeof(ServiceCollectionExtensions).GetTypeInfo().Assembly);
        }
    }
}
