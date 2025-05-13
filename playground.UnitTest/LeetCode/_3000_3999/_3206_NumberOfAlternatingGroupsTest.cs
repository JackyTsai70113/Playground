namespace playground.UnitTest.LeetCode._3000_3999;

public class _3206_NumberOfAlternatingGroupsTest
{
    [Theory]
    [InlineData(new int[] { 1, 1, 1 }, 0)]
    [InlineData(new int[] { 0, 1, 0, 0, 1 }, 3)]
    public void NumberOfAlternatingGroups(int[] nums, int expected)
    {
        var actual = _3206_NumberOfAlternatingGroups.NumberOfAlternatingGroups(nums);
        Assert.Equal(expected, actual);
    }
}
