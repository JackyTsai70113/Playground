namespace playground.UnitTest;

public class SearchRangeTest0034
{
    [Theory]
    [InlineData("[5,7,7,8,8,10]", 8, "[3,4]")]
    [InlineData("[5,7,7,8,8,10]", 6, "[-1,-1]")]
    [InlineData("[7,7,8,8,10]", 6, "[-1,-1]")]
    [InlineData("[]", 0, "[-1,-1]")]
    public void SearchRange(string nums, int target, string expected)
    {
        var actual = SearchRange0034.SearchRange(nums.ToArr(), target);
        Assert.Equal(expected.ToArr(), actual);
    }

    [Theory]
    [InlineData(new int[] { 5, 7, 7, 8, 8, 10 }, 8, 2)]
    [InlineData(new int[] { 5, 7, 7, 8, 8, 10 }, 6, 0)]
    [InlineData(new int[] { 7, 7, 8, 8, 10 }, 6, 0)]
    [InlineData(new int[] { }, 0, 0)]
    public void SearchCount(int[] nums, int target, int expected)
    {
        var actual = SearchRange0034.SearchCount(nums, 0, nums.Length, target);
        Assert.Equal(expected, actual);
    }

    [Theory]
    [InlineData(new int[] { 5, 7, 7, 8, 8, 10 }, 8, 2)]
    [InlineData(new int[] { 5, 7, 7, 8, 8, 10 }, 6, 0)]
    [InlineData(new int[] { 7, 7, 8, 8, 10 }, 6, 0)]
    [InlineData(new int[] { }, 0, 0)]
    public void SearchCount2(int[] nums, int target, int expected)
    {
        var actual = SearchRange0034.SearchCount2(nums, 0, nums.Length, target);
        Assert.Equal(expected, actual);
    }
}
