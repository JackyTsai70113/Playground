namespace playground.UnitTest.LeetCode._3000_3999;

public class _3006_BeautifulIndicesTest
{
    [Theory]
    [InlineData("isawsquirrelnearmysquirrelhouseohmy", "my", "squirrel", 15, "[16,33]")]
    [InlineData("abcd", "a", "a", 4, "[0]")]
    [InlineData("klxtee", "e", "klx", 2, "[]")]
    [InlineData("lahhnlwx", "hhnlw", "ty", 6, "[]")]
    public void BeautifulIndices(string s, string a, string b, int k, string expected)
    {
        var actual = _3006_BeautifulIndices.BeautifulIndices(s, a, b, k);
        Assert.Equal(expected.ToArr(), actual);
    }
}
