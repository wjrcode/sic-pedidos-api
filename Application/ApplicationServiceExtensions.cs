﻿using Application.Queries.Empresas.Handlers;
using Microsoft.Extensions.DependencyInjection;

namespace Application
{
    public static class ApplicationServiceExtensions
    {
        public static IServiceCollection AddApplicationServices(this IServiceCollection services)
        {
            services.AddMediatR(cfg => { cfg.RegisterServicesFromAssembly(typeof(ApplicationServiceExtensions).Assembly); });

            return services;
        }
    }
}
