using playground.Intervals;

namespace playground.UnitTest.Intervals;

public class NumberOfPointsTest
{
    [Theory]
    [InlineData("[[3,6],[1,5],[4,7]]", 7)]
    [InlineData("[[1,3],[5,8]]", 7)]
    [InlineData("[[1,3],[1,8]]", 8)]
    public void NumberOfPoints(string nums, int expected)
    {
        var ll = nums.To2dArr().Cast<IList<int>>().ToList();
        var actual = NumberOfPointsClass.NumberOfPoints(ll);
        Assert.Equal(expected, actual);
    }
}
