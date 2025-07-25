using playground.LeetCode._1000_1999;

namespace playground.UnitTest.LeetCode._1000_1999;

public class _1353_MaxEventsTest
{
    [Theory]
    [InlineData("[[1,2],[2,3],[3,4]]", 3)]
    [InlineData("[[1,2],[2,3],[3,4],[1,2]]", 4)]
    [InlineData("[[1,2],[1,2],[3,3],[1,5],[1,5]]", 5)]
    [InlineData("[[1,2],[1,2],[1,2],[3,3],[1,5],[1,5]]", 5)]
    [InlineData("[[1,2],[1,2],[1,2],[1,5],[1,5]]", 4)]
    [InlineData("[[1,1],[1,4],[2,2],[3,4],[4,4]]", 4)]
    public void MaxEvents(string eventsStr, int expected)
    {
        int result = _1353_MaxEvents.MaxEvents(eventsStr.To2dArr());
        Assert.Equal(expected, result);
    }
}
