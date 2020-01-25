using HelloExample.Models.ResponseModels;

namespace HelloExample
{
    public class HelloAppService : IHelloAppService
    {
        public ResponseSayHello SayHello(string name)
        {
            return new ResponseSayHello {
                Response = $"Hello {name}, how are you?"
            };
        }
    }
}