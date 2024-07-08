namespace playground.UnitTest;

public class NumberOfAlternatingGroupsTest3206
{
    [Theory]
    [InlineData(new int[] { 1, 1, 1 }, 0)]
    [InlineData(new int[] { 0, 1, 0, 0, 1 }, 3)]
    public void NumberOfAlternatingGroups(int[] nums, int expected)
    {
        var actual = NumberOfAlternatingGroups3206.NumberOfAlternatingGroups(nums);
        Assert.Equal(expected, actual);
    }
}
