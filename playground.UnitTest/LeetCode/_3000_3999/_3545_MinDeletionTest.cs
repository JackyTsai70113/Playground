using playground.LeetCode._3000_3999;

namespace playground.UnitTest.LeetCode._3000_3999;

public class _3545_MinDeletionTest
{
    [Theory]
    [InlineData("aabbcc", 2, 2)]
    [InlineData("abc", 2, 1)]
    [InlineData("aabb", 2, 0)]
    [InlineData("yyyzz", 1, 2)]
    public void Test(string s, int k, int expected)
    {
        var actual = _3545_MinDeletion.MinDeletion(s, k);
        Assert.Equal(expected, actual);
    }
}
