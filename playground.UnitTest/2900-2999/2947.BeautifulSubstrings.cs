namespace playground.UnitTest;

public class BeautifulSubstringsTest_2947
{
    [Theory]
    [InlineData("baeyh", 2, 2)]
    [InlineData("abba", 1, 3)]
    [InlineData("bcdf", 1, 0)]
    public void BeautifulSubstrings(string s, int k, int expected)
    {
        var actual = BeautifulSubstrings_2947.BeautifulSubstrings(s, k);
        Assert.Equal(expected, actual);
    }
}
