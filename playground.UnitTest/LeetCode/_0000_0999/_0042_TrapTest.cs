using playground.LeetCode._0000_0999;

namespace playground.UnitTest.LeetCode._0000_0999;

public class _0042_TrapTest
{
    [Theory]
    [InlineData("[0,1,0,2,1,0,1,3,2,1,2,1]", 6)]
    [InlineData("[4,2,0,3,2,5]", 9)]
    public void Trap(string A, int expected)
    {
        var actual = _0042_Trap.Trap(A.ToArr());
        Assert.Equal(expected, actual);
    }

    [Theory]
    [InlineData("[0,1,0,2,1,0,1,3,2,1,2,1]", 6)]
    [InlineData("[4,2,0,3,2,5]", 9)]
    public void Trap2(string A, int expected)
    {
        var actual = _0042_Trap.Trap2(A.ToArr());
        Assert.Equal(expected, actual);
    }
}
