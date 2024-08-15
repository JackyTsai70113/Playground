namespace playground.UnitTest;

public class BalancedStringSplitTest1221
{
    [Theory]
    [InlineData("RLRRLLRLRL", 4)]
    [InlineData("RLRRRLLRLL", 2)]
    [InlineData("LLLLRRRR", 1)]
    public void BalancedStringSplit(string s, int expected)
    {
        var actual = BalancedStringSplit1221.BalancedStringSplit(s);
        Assert.Equal(expected, actual);
    }
}
