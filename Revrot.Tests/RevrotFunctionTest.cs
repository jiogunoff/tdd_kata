using System;
using FluentAssertions;
using Xunit;

namespace Revrot.Tests
{
    public class RevrotFunctionTest
    {
        [Fact]
        public void FirstTest()
        {
            var a = 2;
            var b = 2;

            var sum = a + b;

            sum.Should().Be(4);
        }
    }
}