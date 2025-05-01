using playground._1700_1799;

namespace playground.UnitTest._1700_1799;

public class _1760_MinimumSizeTest
{
    [Theory]
    [InlineData(new int[] { 9 }, 2, 3)]
    [InlineData(new int[] { 2, 4, 8, 2 }, 4, 2)]
    public void MinimumSize(int[] nums, int maxOperations, int expected)
    {
        var actual = _1760_MinimumSize_cs.MinimumSize(nums, maxOperations);
        Assert.Equal(expected, actual);
    }
}
