namespace playground.UnitTest.LeetCode._3000_3999;

public class _3114_FindLatestTimeTest
{
    [Theory]
    [InlineData("?0:?4", "10:54")]
    [InlineData("?1:?4", "11:54")]
    [InlineData("?2:?4", "02:54")]
    [InlineData("??:?4", "11:54")]
    [InlineData("0?:?4", "09:54")]
    [InlineData("1?:4?", "11:49")]
    public void FindLatestTime(string s, string expected)
    {
        var actual = _3114_FindLatestTime.FindLatestTime(s);
        Assert.Equal(expected, actual);
    }
}
