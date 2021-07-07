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

        [Theory]
        [InlineData(-1)]
        [InlineData(0)]
        public void WhenPassChunkSizeLessOrEqualToZeroThenReturnEmptyString(int sz)
        {
            var str = "123";
            
            var result = TDDKata.Revrot(str, sz);

            result.Should().Be("");
        }

        [Theory]
        [InlineData("12", 3)]
        [InlineData("123", 4)]
        public void WhenPassChunkSizeMoreThenStringLengthThenReturnEmptyString(string str, int sz)
        {
            var result = TDDKata.Revrot(str, sz);

            result.Should().Be("");
        }

        [Theory]
        [InlineData("1", 1)]
        [InlineData("2", 1)]
        public void WhenPassChunkSize1WithStringOneSymbolThenReturnThatSymbol(string str, int sz)
        {
            var result = TDDKata.Revrot(str, sz);

            result.Should().Be(str);
        }
    }
}