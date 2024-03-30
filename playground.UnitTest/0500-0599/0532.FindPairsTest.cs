namespace playground.UnitTest;

public class FindPairsTest0532
{
    [Theory]
    [InlineData(new int[] { 3, 1, 4, 1, 5 }, 2, 2)]
    [InlineData(new int[] { 1, 2, 3, 4, 5 }, 1, 4)]
    [InlineData(new int[] { 1, 3, 1, 5, 4 }, 0, 1)]
    public void FindPairs(int[] nums, int k, int expected)
    {
        var actual = FindPairs0532.FindPairs(nums, k);
        Assert.Equal(expected, actual);
        actual = FindPairs0532.FindPairs2(nums, k);
        Assert.Equal(expected, actual);
    }
}
