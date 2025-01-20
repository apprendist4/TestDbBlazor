using System.Reflection;
using Catalog.Architecture.Page;

namespace Catalog.Architecture.Services;

public static class ServiceCollectionExtensions
{
    public static IServiceCollection AddArchitecturePageViewModel(this IServiceCollection services)
    {
        return RegisterClassesDerivedFromBaseClass<PageViewModelBase>(services);
    }



    private static IServiceCollection RegisterClassesDerivedFromBaseClass<TBase>(IServiceCollection services)
    {
       
        var assembly = typeof(TBase).Assembly;

        var derivedTypes = assembly.GetTypes()
            .Where(type => type.IsClass && !type.IsAbstract && type.IsSubclassOf(typeof(TBase)));

        foreach (var derivedType in derivedTypes)
        {
            services.AddScoped(derivedType);
        }

        return services;
    }
}