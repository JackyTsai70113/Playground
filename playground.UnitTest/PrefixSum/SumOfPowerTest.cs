using playground.PrefixSum;

namespace playground.UnitTest.PrefixSum;

public class SumOfPowerTest
{
    [Theory]
    [InlineData(new int[] { 2, 1, 4 }, 141)]
    [InlineData(new int[] { 1, 1, 1 }, 7)]
    public void SumOfPower(int[] nums, int expected)
    {
        var actual = SumOfPowerClass.SumOfPower(nums);
        Assert.Equal(expected, actual);
    }
}
