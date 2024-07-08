namespace playground.UnitTest;

public class MaximumPointsTest3207
{
    [Theory]
    [InlineData(new int[] { 3, 2, 2 }, 1, 0)]
    [InlineData(new int[] { 3, 2, 2 }, 2, 3)]
    [InlineData(new int[] { 2 }, 10, 5)]
    public void MaximumPoints(int[] A, int e, int expected)
    {
        var actual = MaximumPoints3207.MaximumPoints(A, e);
        Assert.Equal(expected, actual);
    }
}
