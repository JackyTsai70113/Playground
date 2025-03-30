namespace playground.UnitTest;

public class _0368_LargestDivisibleSubsetTest
{
    [Theory]
    [InlineData(new int[] { 1, 2, 3 }, new int[] { 1, 2 })]
    [InlineData(new int[] { 1, 2, 4, 8 }, new int[] { 1, 2, 4, 8 })]
    [InlineData(new int[] { 18, 54, 108, 180, 360, 720 }, new int[] { 18, 180, 360, 720 })]
    [InlineData(new int[] { 5, 9, 18, 54, 108, 540, 90, 180, 360, 720 }, new int[] { 9, 18, 90, 180, 360, 720 })]
    public void LargestDivisibleSubset(int[] nums, int[] expected)
    {
        var actual = _0368_LargestDivisibleSubset.LargestDivisibleSubset(nums);
        Assert.Equal(expected, actual.OrderBy(x => x));
    }
}
