using playground.BitManipulation;

namespace playground.UnitTest.BitManipulation;

public class FindKOrClassTest
{
    [Theory]
    [InlineData(new int[] { 7, 12, 9, 8, 9, 15 }, 4, 9)]
    [InlineData(new int[] { 2, 12, 1, 11, 4, 5 }, 6, 0)]
    [InlineData(new int[] { 10, 8, 5, 9, 11, 6, 8 }, 1, 15)]
    public void FindKOr(int[] nums, int k, int expected)
    {
        var actual = FindKOrClass.FindKOr(nums, k);
        Assert.Equal(expected, actual);
    }
}
