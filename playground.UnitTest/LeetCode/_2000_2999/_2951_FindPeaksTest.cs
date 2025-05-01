using playground.LeetCode._2000_2999;

namespace playground.UnitTest.LeetCode._2000_2999;

public class _2951_FindPeaksTest
{
    [Theory]
    [InlineData("[2,4,4]", "[]")]
    [InlineData("[1,4,3,8,5]", "[1,3]")]
    public void FindPeaks(string A, string expected)
    {
        var actual = _2951_FindPeaks.FindPeaks(A.ToArr());
        Assert.Equal(expected.ToArr(), actual);
    }
}
