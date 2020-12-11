using Autofac;
using DDD_API.Domain.Core.Interfaces.Services;
using DDD_API.Domain.Services;
using DDD_API.Domain.Core.Interfaces.Repositories;
using DDD_API.Infrastructure.Data.Repositories;
using System.Collections.Generic;
using Application.DDD_API.Application.Interface.Mappers;
using Application.DDD_API.Application.Interface;
using Application.DDD_API.Application.Mappers;
using Application.DDD_API.Application;


namespace Infrastructure.DDD_API.Infrastructure.CrossCuting.IOC
{
    public class IOCConfiguration
    {

        public static void Load(ContainerBuilder builder)
        {
            #region MyRegion

            builder.RegisterType<ClientServiceApplication>().As<IClientServiceApplication>();
            builder.RegisterType<ProductServiceApplication>().As<IProductServiceApplication>();
            builder.RegisterType<ClientService>().As<IClientService>();
            builder.RegisterType<ProductService>().As<IProductService>();
            builder.RegisterType<ProductRepository>().As<IProductRepository>();
            builder.RegisterType<ClientRepository>().As<IClientRepository>();
            builder.RegisterType<ClientMapper>().As<IClientMapper>();
            builder.RegisterType<ProductMapper>().As<IProductMapper>();

            #endregion
        }
    }
}