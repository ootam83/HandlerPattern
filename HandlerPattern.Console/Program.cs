using Castle.Core.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Castle.Windsor;
using HandlerPattern.Domain.Execution;
using HandlerPattern.Domain.Test.Events;

namespace HandlerPattern.Console
{
    class Program
    {
        static void Main(string[] args)
        {
            var container = new WindsorContainer();

            container.Install(new WindsorInstallerCollection().Installers);

            var logger = container.Resolve<ILogger>();
            var windsor = container.Resolve<IWindsorContainer>();

            logger.Info("Logging via windsor log4net component");

            var handlerplan = new HandlerPlan(windsor);

            var testEvent = new TestEvent { Name = "Blah blah!!"};

            var result = handlerplan.Execute<TestEvent, bool>(testEvent);

        }
    }
}
