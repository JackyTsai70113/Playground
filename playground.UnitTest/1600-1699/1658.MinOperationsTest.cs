using playground._1600_1699;

namespace playground.UnitTest._1600_1699;

public class _1658_MinOperationsTest
{
    [Theory]
    [InlineData(new int[] { 1, 1 }, 3, -1)]
    [InlineData(new int[] { 1, 1, 4, 2, 3 }, 5, 2)]
    [InlineData(new int[] { 5, 6, 7, 8, 9 }, 4, -1)]
    [InlineData(new int[] { 3, 2, 20, 1, 1, 3 }, 10, 5)]
    [InlineData(new int[] { 8828, 9581, 49, 9818, 9974, 9869, 9991, 10000, 10000, 10000, 9999, 9993, 9904, 8819, 1231, 6309 }, 134365, 16)]
    public void MinOperations(int[] nums, int x, int expected)
    {
        var actual = _1658_MinOperations.MinOperations(nums, x);
        Assert.Equal(expected, actual);
    }
}
