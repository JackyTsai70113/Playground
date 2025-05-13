namespace playground.UnitTest.LeetCode._1000_1999;

public class _1614_MaxDepthTest
{
    [Theory]
    [InlineData("", 0)]
    [InlineData("()()", 1)]
    [InlineData("()(()())", 2)]
    [InlineData("(1+(2*3)+((8)/4))+1", 3)]
    [InlineData("(1)+((2))+(((3)))", 3)]
    public void MaxDepth(string s, int expected)
    {
        var actual = _1614_MaxDepth.MaxDepth(s);
        Assert.Equal(expected, actual);
    }
}
