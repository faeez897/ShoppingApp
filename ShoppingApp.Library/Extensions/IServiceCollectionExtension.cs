using Microsoft.Extensions.DependencyInjection;
using ShoppingApp.Library.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoppingApp.Library.Extensions
{
    public static class IServiceCollectionExtension
    {
        public static IServiceCollection AddShoppingAppLibrary(this IServiceCollection services)
        {
            services.AddDbContext<DataContext>();
            return services;
        }
    }
}
