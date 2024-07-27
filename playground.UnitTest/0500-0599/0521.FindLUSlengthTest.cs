namespace playground.UnitTest;

public class FindLUSlengthTest0521
{
    [Theory]
    [InlineData("aba", "cdc", 3)]
    [InlineData("aaa", "bbb", 3)]
    [InlineData("aaa", "aaa", -1)]
    [InlineData("aefawfawfawfaw", "aefawfeawfwafwaef", 17)]
    [InlineData("aefawfeawfwafwaef", "aefawfawfawfaw", 17)]
    public void FindLUSlength(string a, string b, int expected)
    {
        var actual = FindLUSlength0521.FindLUSlength(a, b);
        Assert.Equal(expected, actual);
    }
}
