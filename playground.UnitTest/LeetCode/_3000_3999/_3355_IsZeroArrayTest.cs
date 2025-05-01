using playground._3300_3399;

namespace playground.UnitTest._3300_3399;

public class _3355_IsZeroArrayTest
{
    [Theory]
    [InlineData(new int[] { 1, 0, 1 }, "[[0,2,1],[0,2]]", true)]
    [InlineData(new int[] { 4, 3, 2, 1 }, "[[1,3],[0,2]]", false)]
    [InlineData(new int[] { 7 }, "[[0,0]]", false)]
    public void IsZeroArrayTest(int[] nums, string queries, bool expected)
    {
        var actual = _3355_IsZeroArray.IsZeroArray(nums, queries.To2dArr());
        Assert.Equal(expected, actual);
    }
}
