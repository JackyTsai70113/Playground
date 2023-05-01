using playground.Interval;
using playground.UnitTest.Utils;

namespace playground.UnitTest.Interval;

public class InsertTest
{
    [Theory]
    [InlineData("[[1,3],[6,9]]", "[2,5]", "[[1,5],[6,9]]")]
    [InlineData("[[1,5]]","[0,0]", "[[0,0],[1,5]]")]
    [InlineData("[]","[5,7]", "[[5,7]]")]
    [InlineData("[[0,5],[9,12]]","[7,16]", "[[0,5],[7,16]]")]
    public void Insert(string intervalsStr, string newIntervalStr, string expectedStr)
    {
        var intervals = intervalsStr.To2dArr<int>();
        var newInterval = newIntervalStr.ToArr<int>();
        var actual = InsertClass.Insert(intervals, newInterval);
        Assert.Equal(expectedStr.To2dArr<int>(), actual);
    }
}
