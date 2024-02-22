namespace playground.UnitTest;

public class IsInterleaveTest0097
{
    [Theory]
    [InlineData("aabcc", "dbbca", "aadbbcbcac", true)]
    [InlineData("aabcc", "dbbca", "aadbbbaccc", false)]
    [InlineData("", "", "", true)]
    [InlineData("", "", "a", false)]
    public void IsInterleave(string s1, string s2, string s3, bool expected)
    {
        var actual = IsInterleave0097.IsInterleave(s1, s2, s3);
        Assert.Equal(expected, actual);
    }
}
