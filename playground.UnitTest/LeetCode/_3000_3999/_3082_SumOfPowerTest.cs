namespace playground.UnitTest;

public class _3082_SumOfPowerTest
{
    [Theory]
    [InlineData("[1,2,3]", 3, 6)]
    [InlineData("[2,3,3]", 5, 4)]
    [InlineData("[1,2,3]", 7, 0)]
    [InlineData("[11,7,22,6,3,25,8,22,18,1,14,16,2,1,6,12,19,10,8,1,8,18,15,10,4,4,11,8,16,14,7,11,6,25,2,23,3,15,5,11,6,2,3,7,3,11,10,3,24,20]", 48, 498204821)]
    public void SumOfPower(string nums, int k, int expected)
    {
        var actual = _3082_SumOfPower.SumOfPower(nums.ToArr(), k);
        Assert.Equal(expected, actual);
    }
}
