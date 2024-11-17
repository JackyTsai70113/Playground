using playground._3300_3399;

namespace playground.UnitTest._3300_3399;

public class _3356_MinZeroArrayTest
{
    [Theory]
    [InlineData(new int[] { 2, 0, 2 }, "[[0,2,1],[0,2,1],[1,1,3]]", 2)]
    [InlineData(new int[] { 4, 3, 2, 1 }, "[[1,3,2],[0,2,1]]", -1)]
    [InlineData(new int[] { 0 }, "[[0,0,2],[0,0,4],[0,0,4],[0,0,3],[0,0,5]]", 0)]
    public void MinZeroArray(int[] nums, string queries, int expected)
    {
        var actual = _3356_MinZeroArray.MinZeroArray(nums, queries.To2dArr());
        Assert.Equal(expected, actual);
    }
}
