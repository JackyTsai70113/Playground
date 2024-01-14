namespace playground.UnitTest;

public class BeautifulIndicesTest3006
{
    [Theory]
    [InlineData("isawsquirrelnearmysquirrelhouseohmy", "my", "squirrel", 15, "[16,33]")]
    [InlineData("abcd", "a", "a", 4, "[0]")]
    [InlineData("klxtee", "e", "klx", 2, "[]")]
    [InlineData("lahhnlwx", "hhnlw", "ty", 6, "[]")]
    public void BeautifulIndices(string s, string a, string b, int k, string expected)
    {
        var actual = BeautifulIndices3006.BeautifulIndices(s, a, b, k);
        Assert.Equal(expected.ToArr(), actual);
    }
}
