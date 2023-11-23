namespace playground.UnitTest;

public class CanCompleteCircuitTest
{
    [Theory]
    [InlineData("[1,2,3,4,5]", "[3,4,5,1,2]", 3)]
    [InlineData("[2,3,4]", "[3,4,3]", -1)]
    [InlineData("[2,0,0,0]", "[0,1,0,0]", 0)]
    public void CanCompleteCircuit(string gas, string cost, int expected)
    {
        var actual = CanCompleteCircuit_0134.CanCompleteCircuit(gas.ToArr(), cost.ToArr());
        Assert.Equal(expected, actual);
    }
}
