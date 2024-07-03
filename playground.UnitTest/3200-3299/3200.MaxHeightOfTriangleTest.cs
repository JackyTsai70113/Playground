namespace playground.UnitTest;

public class MaxHeightOfTriangleTest3200
{
    [Theory]
    [InlineData(2, 4, 3)]
    [InlineData(2, 1, 2)]
    [InlineData(1, 1, 1)]
    [InlineData(10, 1, 2)]
    public void MaxHeightOfTriangle(int red, int blue, int expected)
    {
        var actual = MaxHeightOfTriangle3200.MaxHeightOfTriangle(red, blue);
        Assert.Equal(expected, actual);
    }
}
