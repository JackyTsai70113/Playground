using playground.LeetCode._2000_2999;

namespace playground.UnitTest.LeetCode._2000_2999;

public class _2948_LexicographicallySmallestArrayTest
{
    [Theory]
    [InlineData("[1,5,3,9,8]", 2, "[1,3,5,8,9]")]
    [InlineData("[1,7,6,18,2,1]", 3, "[1,6,7,18,1,2]")]
    [InlineData("[1,7,28,19,10]", 3, "[1,7,28,19,10]")]
    public void LexicographicallySmallestArray(string A, int limit, string expected)
    {
        var actual = _2948_LexicographicallySmallestArray.LexicographicallySmallestArray(A.ToArr(), limit);
        Assert.True(Enumerable.SequenceEqual(expected.ToArr(), actual));
    }
}
