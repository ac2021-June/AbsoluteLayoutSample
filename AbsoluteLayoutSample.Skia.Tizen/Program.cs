using Tizen.Applications;
using Uno.UI.Runtime.Skia;

namespace AbsoluteLayoutSample.Skia.Tizen
{
    class Program
    {
        static void Main(string[] args)
        {
            var host = new TizenHost(() => new AbsoluteLayoutSample.App(), args);
            host.Run();
        }
    }
}
