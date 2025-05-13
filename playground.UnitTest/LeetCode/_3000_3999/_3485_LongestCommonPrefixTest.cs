using playground.LeetCode._3000_3999;

namespace playground.UnitTest.LeetCode._3000_3999;

public class _3485_LongestCommonPrefixTest
{
    [Theory]
    [InlineData(new string[] { "jump", "run", "run", "jump", "run" }, 2, new int[] { 3, 4, 4, 3, 4 })]
    [InlineData(new string[] { "dog", "racer", "car" }, 2, new int[] { 0, 0, 0 })]
    public void LongestCommonPrefix(string[] words, int k, int[] expected)
    {
        var actual = _3485_LongestCommonPrefix.LongestCommonPrefix(words, k);
        Assert.Equal(expected, actual);
    }
}
