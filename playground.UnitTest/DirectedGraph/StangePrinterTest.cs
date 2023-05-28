using playground.DynamicPrograming;

namespace playground.UnitTest.DirectedGraph;

public class StangePrinterTest
{
    [Theory]
    [InlineData("ababab", 4)]
    [InlineData("aaabbb", 2)]
    [InlineData("aba", 2)]
    [InlineData("abab", 3)]
    [InlineData("abcabcabc", 7)]
    [InlineData("abababac", 5)]
    [InlineData("aaaa", 1)]
    [InlineData("nwlrbbmqbh", 8)]
    [InlineData("a", 1)]
    [InlineData("aa", 1)]
    [InlineData("ab", 2)]
    [InlineData("cbdbcabda", 6)]
    public void Test(string a, int expected)
    {
        var actual = StangePrinterClass.StrangePrinter(a);
        Assert.Equal(expected, actual);
    }
}
