namespace playground.UnitTest;

public class ValidStringsTest3211
{
    [Theory]
    [InlineData(3, new string[] { "010", "011", "101", "110", "111" })]
    [InlineData(1, new string[] { "0", "1" })]
    public void ValidStrings(int n, IList<string> expected)
    {
        var actual = ValidStrings3211.ValidStrings(n);
        Assert.Equal(expected, actual);
    }
}
