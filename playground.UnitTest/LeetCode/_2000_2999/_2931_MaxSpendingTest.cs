using playground.LeetCode._2000_2999;

namespace playground.UnitTest.LeetCode._2000_2999;

public class _2931_MaxSpendingTest
{
    [Theory]
    [InlineData("[[8,5,2],[6,4,1],[9,7,3]]", 285)]
    [InlineData("[[10,8,6,4,2],[9,7,5,3,2]]", 386)]
    public void MinOperations(string vs, long expected)
    {
        var actual = _2931_MaxSpending.MaxSpending(vs.To2dArr());
        Assert.Equal(expected, actual);
    }
}
