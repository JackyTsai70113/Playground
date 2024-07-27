namespace playground.UnitTest;

public class MinChangesTest3224
{
    [Theory]
    [InlineData(new int[] { 1, 0, 1, 2, 4, 3 }, 4, 2)]
    [InlineData(new int[] { 3, 0, 1, 2, 4, 1 }, 4, 2)]
    [InlineData(new int[] { 0, 1, 2, 3, 3, 6, 5, 4 }, 6, 2)]
    public void MinChanges(int[] nums, int k, int expected)
    {
        var actual = MinChanges3224.MinChanges(nums, k);
        Assert.Equal(expected, actual);
    }
}
