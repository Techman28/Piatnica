using Autofac;
using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ITMCode.Piatnica.Infrastructure.IoC.Modules
{
    public class CommonModule : Autofac.Module
    {

        protected override void Load(ContainerBuilder builder)
        {
            var config = new MapperConfiguration(cfg =>
            {
                cfg.AddProfile<ITMCode.Piatnica.Infrastucture.Mapping.Mapper>();
             });
            builder.RegisterInstance(config.CreateMapper()).As<IMapper>();
        }
    }
}
