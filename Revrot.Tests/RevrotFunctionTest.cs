using System;
using FluentAssertions;
using Xunit;

namespace Revrot.Tests
{
    public class RevrotFunctionTest
    {
        [Fact]
        public void WhenPassEmptyStringThenReturnEmptyString()
        {
            var str = "";
            var sz = 1;

            var result = TDDKata.Revrot(str, sz);

            result.Should().Be("");
        }
    }
}