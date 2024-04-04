namespace playground.UnitTest;

public class MaxDepthTest1614
{
    [Theory]
    [InlineData("", 0)]
    [InlineData("()()", 1)]
    [InlineData("()(()())", 2)]
    [InlineData("(1+(2*3)+((8)/4))+1", 3)]
    [InlineData("(1)+((2))+(((3)))", 3)]
    public void MaxDepth(string s, int expected)
    {
        var actual = MaxDepth1614.MaxDepth(s);
        Assert.Equal(expected, actual);
    }
}
