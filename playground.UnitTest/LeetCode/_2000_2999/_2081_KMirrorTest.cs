using playground.LeetCode._2000_2999;

namespace playground.UnitTest.LeetCode._2000_2999;

public class _2081_KMirrorTest
{
    [Theory]
    [InlineData(2, 5, 25)]
    [InlineData(3, 7, 499)]
    [InlineData(4, 5, 66)]
    [InlineData(7, 17, 20379000)]
    public void TestKMirror(int k, int n, long expected)
    {
        long result = _2081_KMirror.KMirror(k, n);
        Assert.Equal(expected, result);
    }
}

