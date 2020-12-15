using Autofac;

namespace Infrastructure.DDD_API.Infrastructure.CrossCuting.IOC
{
    public class IOCModule : Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            IOCConfiguration.Load(builder);
        }
    }
}