namespace playground.UnitTest;

public class _3010_MinimumCostTest
{
    [Theory]
    [InlineData("[1,2,3,12]", 6)]
    [InlineData("[5,4,3]", 12)]
    [InlineData("[10,3,1,1]", 12)]
    public void MinimumCost(string nums, int expected)
    {
        var actual = _3010_MinimumCost.MinimumCost(nums.ToArr());
        Assert.Equal(expected, actual);
    }
}
