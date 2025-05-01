using playground._3100_3199;

namespace playground.UnitTest._3100_3199;

public class _3191_MinOperationsTest
{
    [Theory]
    [InlineData(new int[] { 0, 1, 1, 1, 0, 0 }, 3)]
    [InlineData(new int[] { 0, 1, 1, 1 }, -1)]
    [InlineData(new int[] { 1, 0, 0, 1, 1, 0, 1, 1, 1 }, -1)]
    public void MinOperations(int[] nums, int expected)
    {
        var actual = _3191_MinOperations.MinOperations(nums);
        Assert.Equal(expected, actual);
    }
}
