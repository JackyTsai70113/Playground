namespace playground.UnitTest;

public class BeautifulSubsetsTest2597
{
    [Theory]
    [InlineData(new int[] { 1, 1, 2 }, 1, 4)]
    [InlineData(new int[] { 1, 1, 2 }, 2, 7)]
    [InlineData(new int[] { 2, 4, 6 }, 2, 4)]
    [InlineData(new int[] { 1 }, 1, 1)]
    public void BeautifulSubsets(int[] nums, int k, int expected)
    {
        var actual = BeautifulSubsets2597.BeautifulSubsets(nums, k);
        Assert.Equal(expected, actual);
    }
}
