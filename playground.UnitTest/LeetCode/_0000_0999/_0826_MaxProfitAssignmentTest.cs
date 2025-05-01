using playground.LeetCode._0000_0999;

namespace playground.UnitTest.LeetCode._0000_0999;

public class _0826_MaxProfitAssignmentTest
{
    [Theory]
    [InlineData("[2,4,6,8,10]", "[10,20,30,40,50]", "[4,5,6,7]", 100)]
    [InlineData("[85,47,57]", "[24,66,99]", "[40,25,25]", 0)]
    [InlineData("[68,35,52,47,86]", "[67,17,1,81,3]", "[92,10,85,84,82]", 324)]
    public void MaxProfitAssignment(string difficulty, string profit, string worker, int expected)
    {
        var actual = _0826_MaxProfitAssignment.MaxProfitAssignment(difficulty.ToArr(), profit.ToArr(), worker.ToArr());
        Assert.Equal(expected, actual);
    }
}
