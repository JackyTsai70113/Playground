namespace playground.UnitTest;

public class RemoveKdigitsTest0402
{
    [Theory]
    [InlineData("1432219", 3, "1219")]
    [InlineData("10200", 1, "200")]
    [InlineData("10", 1, "0")]
    [InlineData("1234567890", 9, "0")]
    [InlineData("123456789", 6, "123")]
    [InlineData("10001", 4, "0")]
    public void RemoveKdigits(string num, int k, string expected)
    {
        var actual = RemoveKdigits0402.RemoveKdigits(num, k);
        Assert.Equal(expected, actual);
    }
}
