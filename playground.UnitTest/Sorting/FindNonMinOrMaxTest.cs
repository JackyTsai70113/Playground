using playground.Sorting;

namespace playground.UnitTest.Sorting;

public class FindNonMinOrMaxTest
{
    [Theory]
    [InlineData(new int[] { 3, 2, 1, 4 }, 2)]
    [InlineData(new int[] { 1, 2 }, -1)]
    [InlineData(new int[] { 2, 1, 3 }, 2)]
    public void FindNonMinOrMax(int[] nums, int expected)
    {
        var actual = FindNonMinOrMaxClass.FindNonMinOrMax(nums);
        Assert.Equal(expected, actual);
    }
}
