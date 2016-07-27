using Castle.MicroKernel.Registration;
using Castle.MicroKernel.SubSystems.Configuration;
using Castle.Windsor;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HandlerPattern.Domain;
using HandlerPattern.Domain.Base;

namespace HandlerPattern.Console.Installers
{
    public class HandlerInstaller : IWindsorInstaller
    {
        public void Install(IWindsorContainer container, IConfigurationStore store)
        {
            container.Register(Classes.FromAssemblyContaining<DomainMarker>()
                .BasedOn(typeof(IHandle<,>))
                .WithServiceAllInterfaces());
                //.LifestylePerThread()
                
        }
    }
}
