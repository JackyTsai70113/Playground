namespace playground.UnitTest;

public class IsAnagramTest0242
{
    [Theory]
    [InlineData("anagrama", "nagaram", false)]
    [InlineData("anagram", "nagaram", true)]
    [InlineData("rat", "car", false)]
    public void IsAnagram(string s, string t, bool expected)
    {
        var actual = IsAnagram0242.IsAnagram(s, t);
        Assert.Equal(expected, actual);
    }
}
