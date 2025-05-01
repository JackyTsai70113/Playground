using playground.LeetCode._0000_0999;

namespace playground.UnitTest.LeetCode._0000_0999;

public class _0134_CanCompleteCircuitTest
{
    [Theory]
    [InlineData("[1,2,3,4,5]", "[3,4,5,1,2]", 3)]
    [InlineData("[2,3,4]", "[3,4,3]", -1)]
    [InlineData("[2,0,0,0]", "[0,1,0,0]", 0)]
    public void CanCompleteCircuit(string gas, string cost, int expected)
    {
        var actual = _0134_CanCompleteCircuit.CanCompleteCircuit(gas.ToArr(), cost.ToArr());
        Assert.Equal(expected, actual);
    }
}
