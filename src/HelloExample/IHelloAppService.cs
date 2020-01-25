using HelloExample.Models.ResponseModels;

namespace HelloExample
{
    public interface IHelloAppService
    {
        ResponseSayHello SayHello(string name);
    }
}