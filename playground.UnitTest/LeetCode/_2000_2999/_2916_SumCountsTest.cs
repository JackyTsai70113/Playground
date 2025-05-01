using playground.LeetCode._2000_2999;

namespace playground.UnitTest.LeetCode._2000_2999;

public class _2916_SumCountsTest
{
    [Theory]
    [InlineData("[5,2,4,2,1,3,2,4,3,1]", 578)]
    [InlineData("[1,2,1]", 15)]
    [InlineData("[2,2]", 3)]
    [InlineData("[2]", 1)]
    public void SumCounts(string num, int expected)
    {
        var actual = new _2916_SumCounts().SumCounts(num.ToArr());
        Assert.Equal(expected, actual);
    }
}
