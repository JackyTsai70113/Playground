namespace playground.UnitTest;

public class FindDuplicateTest0287
{
    [Theory]
    [InlineData(new int[] { 1, 3, 4, 2, 2 }, 2)]
    [InlineData(new int[] { 3, 1, 3, 4, 2 }, 3)]
    [InlineData(new int[] { 3, 3, 3, 3, 3 }, 3)]
    [InlineData(new int[] { 3, 3, 1, 2, 3 }, 3)]
    public void FindDuplicate(int[] nums, int expected)
    {
        var before = nums.ToArray();
        var actual = FindDuplicate0287.FindDuplicate(nums);
        Assert.Equal(expected, actual);
        // ensure we don't modify the array after algorithm
        Assert.Equal(nums, before);
    }
}
