namespace playground.UnitTest;

public class SumOfEncryptedIntTest3079
{
    [Theory]
    [InlineData(new[] { 1, 2, 3 }, 6)]
    [InlineData(new[] { 10, 21, 31 }, 66)]
    public void SumOfEncryptedInt(int[] nums, int expected)
    {
        var actual = SumOfEncryptedInt3079.SumOfEncryptedInt(nums);
        Assert.Equal(expected, actual);
    }
}
