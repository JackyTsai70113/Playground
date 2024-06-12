namespace playground.UnitTest;

public class CountAndSayTest0038
{
    [Theory]
    [InlineData(4, "1211")]
    [InlineData(1, "1")]
    public void CountAndSay(int n, string expected)
    {
        var actual = CountAndSay0038.CountAndSay(n);
        Assert.Equal(expected, actual);
    }
}
