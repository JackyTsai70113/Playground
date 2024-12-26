using playground._3300_3399;

namespace playground.UnitTest._3300_3399;

public class _3397_MaxDistinctElementsTest
{
    [Theory]
    [InlineData(new int[] { 1, 2, 2, 3, 3, 4 }, 2, 6)]
    [InlineData(new int[] { 4, 4, 4, 4 }, 1, 3)]
    [InlineData(new int[] { 6 }, 3, 1)]
    [InlineData(new int[] { 5, 10, 8 }, 3, 3)]
    public void MaxDistinctElements(int[] nums, int k, int expected)
    {
        var actual = _3397_MaxDistinctElements.MaxDistinctElements(nums, k);
        Assert.Equal(expected, actual);
    }
}
