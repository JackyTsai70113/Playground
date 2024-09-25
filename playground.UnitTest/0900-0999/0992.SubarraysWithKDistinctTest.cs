using playground._0900_0999;

namespace playground.UnitTest_0900_0999;

public class _0992_SubarraysWithKDistinctTest
{
    [Theory]
    [InlineData(new int[] { 1, 2, 1, 2, 3 }, 2, 7)]
    [InlineData(new int[] { 1, 2, 1, 3, 4 }, 3, 3)]
    public void SubarraysWithKDistinct(int[] nums, int k, int expected)
    {
        var actual = _0992_SubarraysWithKDistinct.SubarraysWithKDistinct(nums, k);
        Assert.Equal(expected, actual);
    }
}
