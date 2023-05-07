using playground.DynamicPrograming;

namespace playground.UnitTest.DynamicPrograming;

public class NumberOfArraysTest
{
    [Theory]
    [InlineData("1000", 10000, 1)]
    [InlineData("1000", 10, 0)]
    [InlineData("1317", 2000, 8)]
    [InlineData("1317", 100, 5)]
    [InlineData("122", 123, 4)]
    [InlineData("37", 38, 2)]
    [InlineData("1234567890", 90, 34)]
    [InlineData("111111111111111", 1000000000, 16272)]
    [InlineData("604516296181603152696", 696, 35284)]
    public void NumberOfArrays(string s, int k, int expected)
    {
        var actual = NumberOfArraysClass.NumberOfArrays(s, k);
        Assert.Equal(expected, actual);
    }
}
