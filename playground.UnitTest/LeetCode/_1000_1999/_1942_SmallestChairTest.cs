using playground._1900_1999;

namespace playground.UnitTest._1900_1999;

public class _1942_SmallestChairTest
{
    [Theory]
    [InlineData("[[1,4],[2,3],[4,6]]", 2, 0)]
    [InlineData("[[1,4],[2,3],[4,6]]", 1, 1)]
    [InlineData("[[3,10],[1,5],[2,6]]", 0, 2)]
    public void CountPalindromicSubsequence(string times, int targetFriend, int expected)
    {
        var actual = _1942_SmallestChair_cs.SmallestChair(times.To2dArr(), targetFriend);
        Assert.Equal(expected, actual);
    }
}
