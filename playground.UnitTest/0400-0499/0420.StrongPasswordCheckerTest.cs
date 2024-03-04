namespace playground.UnitTest;

public class StrongPasswordCheckerTest0420
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
        var actual = StrongPasswordChecker0420.StrongPasswordChecker(A);
        Assert.Equal(expected, actual);
    }
}
