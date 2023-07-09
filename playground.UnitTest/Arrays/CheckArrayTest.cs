using playground.Arrays;

namespace playground.UnitTest.Arrays;

public class CheckArrayTest
{
    [Theory]
    [InlineData(new int[] { 2, 2, 3, 1, 1, 0 }, 3, true)]
    [InlineData(new int[] { 1, 3, 1, 1 }, 2, false)]
    [InlineData(new int[] { 1 }, 2, false)]
    public void MaxNonDecreasingLength(int[] nums, int k, bool expected)
    {
        var actual = CheckArrayClass.CheckArray(nums, k);
        Assert.Equal(expected, actual);
    }
}
