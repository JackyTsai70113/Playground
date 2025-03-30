using playground._3400_3499;

namespace playground.UnitTest._3400_3499;

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
