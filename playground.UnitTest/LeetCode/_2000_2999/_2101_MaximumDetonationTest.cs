using playground.LeetCode._2000_2999;

namespace playground.UnitTest.LeetCode._2000_2999;

public class _2101_MaximumDetonationTest
{
    [Theory]
    [InlineData("[[1,1,5],[10,10,5]]", 1)]
    [InlineData("[[1,2,3],[2,3,1],[3,4,2],[4,5,3],[5,6,4]]", 5)]
    public void MaximumDetonation(string bs, int expected)
    {
        var actual = _2101_MaximumDetonation.MaximumDetonation(bs.To2dArr());
        Assert.Equal(expected, actual);
    }
}
