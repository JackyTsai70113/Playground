using playground.LeetCode._2000_2999;

namespace playground.UnitTest.LeetCode._2000_2999;

public class _2402_MostBookedTest
{
    [Theory]
    [InlineData(2, "[[0,10],[1,5],[2,7],[3,4]]", 0)]
    [InlineData(3, "[[1,20],[2,10],[3,5],[4,9],[6,8]]", 1)]
    [InlineData(3, "[[2,10],[1,20],[3,5],[4,9],[6,8]]", 1)]
    [InlineData(2, "[[0,10],[1,2],[12,14],[13,15]]", 0)]
    public void MostBooked(int n, string meetings, int expected)
    {
        var result = _2402_MostBooked.MostBooked(n, meetings.To2dArr());
        Assert.Equal(expected, result);
    }
}
