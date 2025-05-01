using playground.LeetCode._2000_2999;

namespace playground.UnitTest.LeetCode._2000_2999;

public class _2812_MaximumSafenessFactorTest
{
    [Theory]
    [InlineData("[[1,0,0],[0,0,0],[0,0,1]]", 0)]
    [InlineData(" [[0,0,1],[0,0,0],[0,0,0]]", 2)]
    [InlineData("[[0,0,0,1],[0,0,0,0],[0,0,0,0],[1,0,0,0]]", 2)]
    public void MaximumSafenessFactor(string A, int expected)
    {
        var actual = _2812_MaximumSafenessFactor.MaximumSafenessFactor(A.To2dArr());
        Assert.Equal(expected, actual);
    }
}
