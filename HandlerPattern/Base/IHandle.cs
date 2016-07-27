
namespace HandlerPattern.Domain.Base
{
    public interface IHandle<in TEventDto, TReturn>
    {
         void Handle(TEventDto eventDto, HandleResult<TReturn> result);
    }
}
