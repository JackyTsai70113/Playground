using playground.Strings;

namespace playground.UnitTest.Strings;

public class CheckStringsTest
{
    [Theory]
    [InlineData("abcdba", "cabdab", true)]
    [InlineData("abe", "bea", false)]
    [InlineData("abe", "bba", false)]
    [InlineData("abe", "eqa", false)]
    public void CheckStrings(string s1, string s2, bool expected)
    {
        var actual = CheckStringsClass.CheckStrings(s1, s2);

        Assert.Equal(expected, actual);
    }
}
