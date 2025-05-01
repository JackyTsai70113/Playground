using playground.LeetCode._0000_0999;

namespace playground.UnitTest.LeetCode._0000_0999;

public class _0054_SpiralOrderTest
{
    [Theory]
    [InlineData("[[1,2,3],[4,5,6],[7,8,9]]", "[1,2,3,6,9,8,7,4,5]")]
    [InlineData("[[1,2,3,4],[5,6,7,8],[9,10,11,12]]", "[1,2,3,4,8,12,11,10,9,5,6,7]")]
    public void SpiralOrder(string A, string expected)
    {
        var actual = _0054_SpiralOrder.SpiralOrder(A.To2dArr());
        Assert.Equal(expected.ToArr(), actual);
    }
}
