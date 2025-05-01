namespace playground.UnitTest;

public class _3098_SumOfPowersTest
{
    [Theory]
    [InlineData(new int[] { 1, 2, 3, 4 }, 3, 4)]
    [InlineData(new int[] { 2, 2 }, 2, 0)]
    [InlineData(new int[] { 4, 3, -1 }, 2, 10)]
    [InlineData(new int[] { -24, -921, 119, -291, -65, -628, 372, 274, 962, -592, -10, 67, -977, 85, -294, 349, -119, -846, -959, -79, -877, 833, 857, 44, 826, -295, -855, 554, -999, 759, -653, -423, -599, -928 }, 19, 990202285)]
    public void SumOfPowers(int[] nums, int k, int expected)
    {
        var actual = _3098_SumOfPowers.SumOfPowers(nums, k);
        Assert.Equal(expected, actual);
    }
}
