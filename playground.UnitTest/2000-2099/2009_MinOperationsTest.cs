using playground._2000_2099;

namespace playground.UnitTest._2000_2099;

public class _2009_MinOperationsTest
{
    [Theory]
    [InlineData(new int[] { 4, 2, 5, 3 }, 0)]
    [InlineData(new int[] { 1, 2, 3, 5, 6 }, 1)]
    [InlineData(new int[] { 1, 10, 100, 1000 }, 3)]
    [InlineData(new int[] { 1, 2, 3, 10, 20 }, 2)]
    public void MinOperations(int[] nums, int expected)
    {
        var actual = _2009_MinOperations.MinOperations(nums);
        Assert.Equal(expected, actual);
    }
}
