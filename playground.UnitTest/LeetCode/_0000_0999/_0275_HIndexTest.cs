using playground.LeetCode._0000_0999;

namespace playground.UnitTest.LeetCode._0000_0999;

public class _0275_HIndexTest
{
    [Theory]
    [InlineData("[0,1,3,5,6]", 3)]
    [InlineData("[1,2,100]", 2)]
    [InlineData("[1,1,3]", 1)]
    public void HIndex(string A, int expected)
    {
        var actual = _0275_HIndex.HIndex(A.ToArr());
        Assert.Equal(expected, actual);
    }
}
