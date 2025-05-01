namespace playground.UnitTest;

public class _3207_MaximumPointsTest
{
    [Theory]
    [InlineData(new int[] { 3, 2, 2 }, 1, 0)]
    [InlineData(new int[] { 3, 2, 2 }, 2, 3)]
    [InlineData(new int[] { 2 }, 10, 5)]
    public void MaximumPoints(int[] A, int e, int expected)
    {
        var actual = _3207_MaximumPoints.MaximumPoints(A, e);
        Assert.Equal(expected, actual);
    }
}
