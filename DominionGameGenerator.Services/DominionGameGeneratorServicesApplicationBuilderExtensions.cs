using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using Microsoft.Extensions.DependencyInjection;
using DominionGameGenerator.Services;
using System.Reflection;
using AutoMapper;

namespace Microsoft.AspNetCore.Builder
{
    public static class DominionGameGeneratorServicesApplicationBuilderExtensions
    {
        public static void AddDominionGameGeneratorServices(this IServiceCollection services)
        {
            // Configure services for the Data Layer
            services.AddDominionGameGeneratorData();

            // Configure Automapper
            IMapper mapper = new MapperConfiguration(cfg => cfg.AddProfile(new AutoMapperProfile())).CreateMapper();
            services.AddSingleton(typeof(IMapper), mapper);

            // Configure the default types for this project
            var assembly = typeof(DominionGameGeneratorServicesApplicationBuilderExtensions).GetTypeInfo().Assembly;
            services.AddDefaultServices(assembly);
        }
    }
}
