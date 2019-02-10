using K2V.SamplePackage;
using Xunit;

namespace K2V.SampleProject.Tests
{
    public class SayTests
    {
        [Fact]
        public void Calling_Say_Hello_Returns_Hello()
        {
            Assert.Equal("Hello", Say.Hello());
        }
    }
}
