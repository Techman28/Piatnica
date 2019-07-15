using Autofac;
 using ITMCode.Piatnica.Dal.Repository;
using ITMCode.Piatnica.Dal.UnitOfWork;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace ITMCode.Piatnica.Infrastructure.IoC.Modules
{

    public class RepositoryModule : Autofac.Module
    {

        protected override void Load(ContainerBuilder builder)
        {
            var assembly = typeof(IRepository)
            .GetTypeInfo()
            .Assembly;

            builder.RegisterAssemblyTypes(assembly)
                .Where(w => w.IsAssignableTo<IRepository>())
                .AsImplementedInterfaces()
                .InstancePerLifetimeScope();
            builder.RegisterType<UnitOfWork>().As<IUnitOfWork>();

        }
    }

}
