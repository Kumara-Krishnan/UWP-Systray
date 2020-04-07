using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Text;


namespace DomainLogic
{
    public sealed class DIServiceProvider
    {
        public static DIServiceProvider Instance { get { return DIServiceProviderSingleton.Instance; } }

        private readonly IServiceProvider ServiceProvider;

        private DIServiceProvider()
        {
            var serviceCollection = new ServiceCollection();
            serviceCollection.AddSingleton<Class1, Class1>();
            ServiceProvider = serviceCollection.BuildServiceProvider();
        }

        public T GetService<T>()
        {
            return ServiceProvider.GetService<T>();
        }

        class DIServiceProviderSingleton
        {
            static DIServiceProviderSingleton() { }

            internal static readonly DIServiceProvider Instance = new DIServiceProvider();
        }
    }
}