using Foo.Logging;

namespace Foo
{
    public class Class1
    {
        public Class1()
        {
            var log = LogProvider.For<Class1>();
            log.Info("Test");
        }
    }
}
