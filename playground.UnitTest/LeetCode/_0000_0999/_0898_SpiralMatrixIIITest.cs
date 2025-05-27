using playground.LeetCode._0000_0999;

namespace playground.UnitTest.LeetCode._0000_0999;

public class _0898_SubarrayBitwiseORsTest
{
    [Theory]
    [InlineData(new int[] { 0 }, 1)]
    [InlineData(new int[] { 1, 1, 2 }, 3)]
    [InlineData(new int[] { 1, 2, 4 }, 6)]
    public void SubarrayBitwiseORs(int[] arr, int expected)
    {
        var actual = _0898_SubarrayBitwiseORs.SubarrayBitwiseORs(arr);
        Assert.Equal(expected, actual);
    }
}
