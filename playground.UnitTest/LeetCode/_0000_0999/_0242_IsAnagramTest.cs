using playground.LeetCode._0000_0999;

namespace playground.UnitTest.LeetCode._0000_0999;

public class _0242_IsAnagramTest
{
    [Theory]
    [InlineData("anagrama", "nagaram", false)]
    [InlineData("anagram", "nagaram", true)]
    [InlineData("rat", "car", false)]
    public void IsAnagram(string s, string t, bool expected)
    {
        var actual = _0242_IsAnagram.IsAnagram(s, t);
        Assert.Equal(expected, actual);
    }
}
