using playground._3300_3399;

namespace playground.UnitTest.LeetCode._3000_3999;

public class _3302_ValidSequenceTest
{
    [Theory]
    [InlineData("vbcca", "abc", new int[] { 0, 1, 2 })]
    [InlineData("bacdc", "abc", new int[] { 1, 2, 4 })]
    [InlineData("aaaaaa", "aaabc", new int[] { })]
    [InlineData("abc", "ab", new int[] { 0, 1 })]
    public void ValidSequence(string a, string b, int[] expected)
    {
        var actual = _3302_ValidSequence.ValidSequence(a, b);
        Assert.Equal(expected, actual);
    }
}
