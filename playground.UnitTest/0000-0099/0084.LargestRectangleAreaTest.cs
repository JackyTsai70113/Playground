namespace playground.UnitTest;

public class LargestRectangleAreaTest0084
{
    [Theory]
    [InlineData("[2,1,5,6,2,3]", 10)]
    [InlineData("[2,4]", 4)]
    public void LargestRectangleArea(string A, int expected)
    {
        var actual = LargestRectangleArea0084.LargestRectangleArea(A.ToArr());
        Assert.Equal(expected, actual);
    }

    [Theory]
    [InlineData("[2,1,5,6,2,3]", 10)]
    [InlineData("[2,4]", 4)]
    public void LargestRectangleArea2(string A, int expected)
    {
        var actual = LargestRectangleArea0084.LargestRectangleArea2(A.ToArr());
        Assert.Equal(expected, actual);
    }
}
