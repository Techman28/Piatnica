using Autofac;
using Autofac.Extras.NLog;
using ITMCode.Piatnica.Infrastructure.IoC.Modules;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ITMCode.Piatnica.Infrastructure.IoC
{
    public class ContainerModule : Autofac.Module
    {

        protected override void Load(ContainerBuilder builder)
        {
            builder.RegisterModule<RepositoryModule>();
            builder.RegisterModule<ServiceModule>();
            builder.RegisterModule<CommonModule>();
         }
    }
}
