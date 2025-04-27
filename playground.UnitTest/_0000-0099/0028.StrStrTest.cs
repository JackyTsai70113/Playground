namespace playground.UnitTest;

public class StrStrTest_0028
{
    [Theory]
    [InlineData("sadbutsad", "sad", 0)]
    [InlineData("leetcode", "leeto", -1)]
    [InlineData("leetcode", "leetcodeaa", -1)]
    public void StrStr(string A, string B, int expected)
    {
        var actual = StrStr_0028.StrStr(A, B);
        Assert.Equal(expected, actual);
    }
}
