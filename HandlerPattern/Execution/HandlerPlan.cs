using Castle.Core.Logging;
using Castle.Windsor;
using HandlerPattern.Domain.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HandlerPattern.Domain.Execution
{
    public class HandlerPlan
    {
        private readonly IWindsorContainer _container;
        public ILogger _log { get; set; }

        public HandlerPlan(IWindsorContainer container)
        {
            _container = container;
        }

        public HandleResult<TReturn> Execute<TEventDto, TReturn>(TEventDto eventDto)
        {
            var handlers = _container.ResolveAll<IHandle<TEventDto, TReturn>>();

            //_log.InfoFormat("Found {0} handler(s) for {1}", handlers.Count(), typeof(TEventDto));

            var handlerExecute = handlers.First();

            var result = new HandleResult<TReturn>();

            handlerExecute.Handle(eventDto, result);

            return result;
        }

        private void ExecuteHandler<TEventDto, TReturn>(TEventDto eventDto, HandleResult<TReturn> result, IHandle<TEventDto, TReturn> handler)
        {
            try
            {
                handler.Handle(eventDto, result);
            }
            finally
            {
                _container.Release(handler);
            }
        }

    }
}
