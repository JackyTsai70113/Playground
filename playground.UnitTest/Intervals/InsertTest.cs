using playground.Intervals;

namespace playground.UnitTest.Intervals;

public class InsertTest
{
    [Theory]
    [InlineData("[[1,3],[6,9]]", new int[] { 2, 5 }, "[[1,5],[6,9]]")]
    [InlineData("[[1,5]]", new int[] { 0, 0 }, "[[0,0],[1,5]]")]
    [InlineData("[]", new int[] { 5, 7 }, "[[5,7]]")]
    [InlineData("[[0,5],[9,12]]", new int[] { 7, 16 }, "[[0,5],[7,16]]")]
    public void Insert(string intervals, int[] newInterval, string expected)
    {
        var actual = InsertClass.Insert(intervals.To2dArr(), newInterval);
        Assert.Equal(expected.To2dArr(), actual);
    }
}
