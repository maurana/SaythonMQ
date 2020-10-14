using System.Collections.Generic;
using Microsoft.Extensions.DependencyInjection;

namespace SaythonMQ.System
{
    public static class Handling
    {
        public static IServiceCollection AddEventBusHandling<T>(this IServiceCollection services, IEnumerable<T> handlers)
        {
            foreach (var handler in handlers)
            {
                services.AddTransient(handler.GetType());
            }

            return services;
        }
    }
}
