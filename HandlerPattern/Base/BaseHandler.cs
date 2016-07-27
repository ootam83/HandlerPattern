using Castle.Core.Logging;


namespace HandlerPattern.Domain.Base
{
    public abstract class BaseHandler<TEventDto, TReturn> : IHandle<TEventDto, TReturn>
    {
        public ILogger Logger { get; set; }
        public void Handle(TEventDto eventDto, HandleResult<TReturn> result)
        {
            InternalHandle(eventDto, result);
        }


        protected abstract void  InternalHandle(TEventDto eventDto, HandleResult<TReturn> result);
    }
}
