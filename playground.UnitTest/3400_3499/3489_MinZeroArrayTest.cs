using playground._3400_3499;

namespace playground.UnitTest._3400_3499;

public class _3489_MinZeroArrayTest
{
    [Theory]
    [InlineData(new int[] { 2, 0, 2 }, "[[0,2,1],[0,2,1],[1,1,3]]", 2)]
    public void MinZeroArray(int[] nums, string queries, int expected)
    {
        var actual = _3489_MinZeroArray.MinZeroArray(nums, queries.To2dArr());
        Assert.Equal(expected, actual);
    }
}
