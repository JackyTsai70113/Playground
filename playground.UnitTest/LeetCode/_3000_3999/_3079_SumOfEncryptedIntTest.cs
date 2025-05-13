namespace playground.UnitTest.LeetCode._3000_3999;

public class _3079_SumOfEncryptedIntTest
{
    [Theory]
    [InlineData(new[] { 1, 2, 3 }, 6)]
    [InlineData(new[] { 10, 21, 31 }, 66)]
    public void SumOfEncryptedInt(int[] nums, int expected)
    {
        var actual = _3079_SumOfEncryptedInt.SumOfEncryptedInt(nums);
        Assert.Equal(expected, actual);
    }
}
