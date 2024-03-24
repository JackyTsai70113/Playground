namespace playground.UnitTest;

public class FindDuplicatesTest0442
{
    [Theory]
    [InlineData(new[] { 4, 3, 2, 7, 8, 2, 3, 1 }, new[] { 2, 3 })]
    [InlineData(new[] { 1, 1, 2 }, new[] { 1 })]
    [InlineData(new[] { 1 }, new int[] { })]
    public void FindDuplicates(int[] nums, int[] expected)
    {
        var before = nums.ToArray();
        var actual = FindDuplicates0442.FindDuplicates(nums);
        Assert.Equal(expected, actual);
        // ensure we don't modify the array after algorithm
        Assert.Equal(nums, before);
    }
}
