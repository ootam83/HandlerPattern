
namespace HandlerPattern.Domain.Base
{
    public class HandleResult<TResult>
    {
        public TResult Response { get; private set; }

        public void Processed(TResult response)
        {
            Response = response;
        }
    }
}
