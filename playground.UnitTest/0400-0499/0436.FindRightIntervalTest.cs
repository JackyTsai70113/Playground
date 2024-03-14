namespace playground.UnitTest;

public class FindRightIntervalTest0436
{
    [Theory]
    [InlineData("[[1,2]]", "[-1]")]
    [InlineData("[[3,4],[2,3],[1,2]]", "[-1,0,1]")]
    [InlineData("[[1,4],[2,3],[3,4]]", "[-1,2,-1]")]
    public void FindRightInterval(string intervals, string expected)
    {
        var actual = FindRightInterval0436.FindRightInterval(intervals.To2dArr());
        Assert.Equal(expected.ToArr(), actual);
    }
}
