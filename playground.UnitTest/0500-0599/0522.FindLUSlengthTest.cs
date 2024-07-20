namespace playground.UnitTest;

public class FindLUSlengthTest0522
{
    [Theory]
    [InlineData(new string[] { "aba", "cdc", "eae" }, 3)]
    [InlineData(new string[] { "aaa", "aaa", "aa" }, -1)]
    [InlineData(new string[] { "aaa", "aaa", "ab" }, 2)]
    [InlineData(new string[] { "aaa", "aaa", "ab", "aa" }, 2)]
    [InlineData(new string[] { "aaa", "aaa", "ac", "ab" }, 2)]
    [InlineData(new string[] { "aaa", "acb" }, 3)]
    [InlineData(new string[] { "aabbcc", "aabbcc", "bc", "bcc", "aabbccc" }, 7)]
    [InlineData(new string[] { "abcabc", "abcabc", "abcabc", "abc", "abc", "aab" }, -1)]
    [InlineData(new string[] { "abcabc", "abcabc", "abcabc", "abc", "abc", "aa" }, -1)]
    [InlineData(new string[] { "abcabc", "abcabc", "abcabc", "abc", "abc", "bb" }, -1)]
    public void FindLUSlength(string[] strs, int expected)
    {
        var actual = FindLUSlength0522.FindLUSlength(strs);
        Assert.Equal(expected, actual);
    }
}
