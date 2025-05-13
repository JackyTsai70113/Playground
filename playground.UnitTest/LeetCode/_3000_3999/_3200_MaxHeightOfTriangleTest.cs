namespace playground.UnitTest.LeetCode._3000_3999;

public class _3200_MaxHeightOfTriangleTest
{
    [Theory]
    [InlineData(2, 4, 3)]
    [InlineData(2, 1, 2)]
    [InlineData(1, 1, 1)]
    [InlineData(10, 1, 2)]
    public void MaxHeightOfTriangle(int red, int blue, int expected)
    {
        var actual = _3200_MaxHeightOfTriangle.MaxHeightOfTriangle(red, blue);
        Assert.Equal(expected, actual);
    }
}
