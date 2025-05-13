namespace playground.UnitTest.LeetCode._1000_1999;

public class _1608_SpecialArrayTest
{
    [Theory]
    [InlineData(new int[] { 3, 5 }, 2)]
    [InlineData(new int[] { 0, 0 }, -1)]
    [InlineData(new int[] { 0, 4, 3, 0, 4 }, 3)]
    [InlineData(new int[] { 3, 6, 7, 7, 0 }, -1)]
    public void SpecialArray(int[] nums, int expected)
    {
        var actual = _1608_SpecialArray.SpecialArray(nums);
        Assert.Equal(expected, actual);
    }
}
