using playground.LeetCode._0000_0999;

namespace playground.UnitTest.LeetCode._0000_0999;

public class _0420_StrongPasswordCheckerTest
{
    [Theory]
    [InlineData("a", 5)]
    [InlineData("aA1", 3)]
    [InlineData("1337C0d3", 0)]
    [InlineData("Baaabb0", 1)]
    [InlineData("1111111111", 3)]
    [InlineData("bbaaaaaaaaaaaaaaacccccc", 8)]
    public void RemoveKdigits(string A, int expected)
    {
        var actual = _0420_StrongPasswordChecker.StrongPasswordChecker(A);
        Assert.Equal(expected, actual);
    }
}
