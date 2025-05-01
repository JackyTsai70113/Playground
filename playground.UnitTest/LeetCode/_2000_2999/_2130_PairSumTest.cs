using playground.LeetCode._2000_2999;

namespace playground.UnitTest.LeetCode._2000_2999;

public class _2130_PairSumTest
{
    [Theory]
    [InlineData("[5,3]", 8)]
    [InlineData("[5,3,2,1]", 6)]
    [InlineData("[5,4,2,1]", 6)]
    [InlineData("[5,5,2,1]", 7)]
    public void PairSum(string a, int expected)
    {
        var actual = _2130_PairSum.PairSum(a.ToListNode());
        Assert.Equal(expected, actual);
    }
}
