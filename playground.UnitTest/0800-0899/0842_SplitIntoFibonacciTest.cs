using playground._0800_0899;

namespace playground.UnitTest._0800_0899;

public class _0842_SplitIntoFibonacciTest
{
    [Theory]
    [InlineData("1101111", new int[] { 11, 0, 11, 11 })]
    [InlineData("5491322355792149241", new int[] { 5, 4, 9, 13, 22, 35, 57, 92, 149, 241 })]
    [InlineData("112358130", new int[] { })]
    [InlineData("0123", new int[] { })]
    [InlineData("21474836482147483647", new int[] { })]
    public void SplitIntoFibonacci(string num, int[] expected)
    {
        var actual = _0842_SplitIntoFibonacci.SplitIntoFibonacci(num);
        Assert.Equal(expected, actual);
    }
}
