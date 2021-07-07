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

        [Theory]
        [InlineData("123", 1)]
        [InlineData("222", 1)]
        public void WhenPassChunkSize1WithStringAnySymbolsThenReturnThatString(string str, int sz)
        {
            var result = TDDKata.Revrot(str, sz);

            result.Should().Be(str);
        }

        [Fact]
        public void WhenPassOneChunkWithSize2AndSumOfCubesDivisibleBy2ThenReturnReverseString()
        {
            var str = "24";
            var sz = 2;

            var result = TDDKata.Revrot(str, sz);

            result.Should().Be("42");
        }

        [Fact]
        public void WhenPassOneChunkWithSize3AndSumOfCubesDivisibleBy2ThenReturnReverseString()
        {
            var str = "248";
            var sz = 3;

            var result = TDDKata.Revrot(str, sz);

            result.Should().Be("842");
        }

        [Fact]
        public void WhenPassOneChunkWithSize3AndSumOfCubesDoesNotDivisibleBy2ThenReturnStringRotatedLeftOnePosition()
        {
            var str = "148";
            var sz = 3;

            var result = TDDKata.Revrot(str, sz);

            result.Should().Be("481");
        }

        [Fact]
        public void WhenPassTwoChunksWithSize3AndFirstChunkSumOfCubesDivisibleBy2AndSecondDoesNotThenReturnCorrectString()
        {
            var str = "248148";
            var sz = 3;

            var result = TDDKata.Revrot(str, sz);

            result.Should().Be("842481");
        }
    }
}