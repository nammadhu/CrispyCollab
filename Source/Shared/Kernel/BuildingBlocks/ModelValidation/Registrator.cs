﻿using Microsoft.Extensions.DependencyInjection;

namespace Shared.Kernel.BuildingBlocks.ModelValidation
{
    public static class Registrator
    {
        public static IServiceCollection RegisterModelValidationService(this IServiceCollection services)
        {
            return services.AddScoped<IValidationService, ValidationService>();
        }
    }
}
