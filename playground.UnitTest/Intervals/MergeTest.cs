using playground.Intervals;

namespace playground.UnitTest.Intervals;

public class MergeTest
{
    [Theory]
    [InlineData("[[1,3],[2,6],[8,10],[15,18]]", "[[1,6],[8,10],[15,18]]")]
    [InlineData("[[1,4],[4,5]]", "[[1,5]]")]
    [InlineData("[[1,4],[0,2],[3,5]]", "[[0,5]]")]
    [InlineData("[[1,4],[1,2],[3,5]]", "[[1,5]]")]
    public void Merge(string intervals, string expectedStr)
    {
        var actual = MergeClass.Merge(intervals.To2dArr());
        Assert.Equal(expectedStr.To2dArr(), actual);
    }
}
