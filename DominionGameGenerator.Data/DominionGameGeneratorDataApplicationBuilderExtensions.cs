using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.Extensions.DependencyInjection;
using System.Reflection;

namespace Microsoft.AspNetCore.Builder
{
    public static class DominionGameGeneratorDataApplicationBuilderExtensions
    {
        public static void AddDominionGameGeneratorData(this IServiceCollection services)
        {
            var assembly = typeof(DominionGameGeneratorDataApplicationBuilderExtensions).GetTypeInfo().Assembly;
            services.AddDefaultServices(assembly);
        }
    }
}
