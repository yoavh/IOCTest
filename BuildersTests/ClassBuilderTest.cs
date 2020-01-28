using System;
using Xunit;
using Builders;

namespace BuildersTests
{
    public class ClassBuilderTest
    {
        [Fact]
        public void BuildTest()
        {
            var builder = new ClassBuilder();
            var  classString = builder.Build("yoav_namesapce","yoav_class");
        }
    }
}
