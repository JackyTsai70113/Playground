namespace playground.UnitTest;

public class LargestDivisibleSubsetTest0368
{
    [Theory]
    [InlineData(new int[] { 1, 2, 3 }, new int[] { 1, 2 })]
    [InlineData(new int[] { 1, 2, 4, 8 }, new int[] { 1, 2, 4, 8 })]
    [InlineData(new int[] { 18, 54, 108, 180, 360, 720 }, new int[] { 18, 180, 360, 720 })]
    [InlineData(new int[] { 5, 9, 18, 54, 108, 540, 90, 180, 360, 720 }, new int[] { 9, 18, 90, 180, 360, 720 })]
    public void LargestDivisibleSubset(int[] nums, int[] expected)
    {
        var actual = LargestDivisibleSubset0368.LargestDivisibleSubset(nums);
        Assert.Equal(expected.OrderBy(x => x), actual.OrderBy(x => x));
    }
}
