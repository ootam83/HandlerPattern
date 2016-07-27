using HandlerPattern.Domain.Base;
using System;
using HandlerPattern.Domain.Test.Events;
using Castle.Core.Logging;

namespace HandlerPattern.Domain.Test.Handlers
{
    public class TestHandler : BaseHandler<TestEvent, bool>
    {
        protected override void InternalHandle(TestEvent eventDto, HandleResult<bool> result)
        {
            //Logger.InfoFormat("Handler {0} being executed", this.GetType().ToString());
            result.Processed(true);
        }
    }
}
