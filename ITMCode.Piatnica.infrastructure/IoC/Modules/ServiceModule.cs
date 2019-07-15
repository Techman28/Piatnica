using Autofac;
using ITMCode.Piatnica.Bll;
using ITMCode.Piatnica.Bll.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace ITMCode.Piatnica.Infrastructure.IoC.Modules
{
    public class ServiceModule : Autofac.Module
    {

        protected override void Load(ContainerBuilder builder)
        {

            var assembly = typeof(IService)
            .GetTypeInfo()
            .Assembly;

            builder.RegisterAssemblyTypes(assembly)
                .Where(w => w.IsAssignableTo<IService>())
                .AsImplementedInterfaces()
                .InstancePerLifetimeScope();
            builder.RegisterType<ServiceFactory>().As<IServiceFactory>();
        }
    }
}
