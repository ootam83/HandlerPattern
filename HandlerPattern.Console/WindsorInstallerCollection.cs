using Castle.MicroKernel.Registration;
using HandlerPattern.Console.Installers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HandlerPattern.Console
{
    public class WindsorInstallerCollection
    {
        public IWindsorInstaller[] Installers
        {
            get
            {
                return new IWindsorInstaller[]
                {
                    new LoggerInstaller(),
                    new HandlerInstaller(),
                    new WindsorInstaller()
                };
            }
        }
    }
}
