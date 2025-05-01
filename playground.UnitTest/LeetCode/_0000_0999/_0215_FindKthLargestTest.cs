using playground.LeetCode._0000_0999;

namespace playground.UnitTest.LeetCode._0000_0999;

public class _0215_FindKthLargestTest
{
    [Theory]
    [InlineData("[3,2,1,5,6,4]", 2, 5)]
    [InlineData("[3,2,3,1,2,4,5,5,6]", 4, 4)]
    public void FindMin(string num, int k, int expected)
    {
        var actual = _0215_FindKthLargest.FindKthLargest(num.ToArr(), k);
        Assert.Equal(expected, actual);
    }
}
