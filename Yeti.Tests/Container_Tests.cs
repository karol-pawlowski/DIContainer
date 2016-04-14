using Shouldly;
using Xunit;
using Yeti;

namespace Yeti.Tests
{
    public class Container_Tests
    {
        [Fact]
        public void Resolves_Registered_Instance()
        {
            var container = new Container();
            container.Register<ITest, Test>();

            var resolved = container.Resolve<ITest>();
            resolved.ShouldBeOfType<ITest>();
        }
    }

    public interface ITest
    {
        void Call();
    }

    public class Test : ITest
    {
        public void Call()
        {
            throw new System.NotImplementedException();
        }
    }
}
