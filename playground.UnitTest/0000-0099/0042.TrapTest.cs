namespace playground.UnitTest;

public class TrapTest_0042
{
    [Theory]
    [InlineData("[0,1,0,2,1,0,1,3,2,1,2,1]", 6)]
    [InlineData("[4,2,0,3,2,5]", 9)]
    public void Trap(string A, int expected)
    {
        var actual = Trap_0042.Trap(A.ToArr());
        Assert.Equal(expected, actual);
    }
}
