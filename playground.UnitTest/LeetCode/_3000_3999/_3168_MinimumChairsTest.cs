namespace playground.UnitTest;

public class _3168_MinimumChairsTest
{
    [Theory]
    [InlineData("EEEEEEE", 7)]
    [InlineData("ELELEEL", 2)]
    [InlineData("ELEELEELLL", 3)]
    public void MinimumChairs(string s, int expected)
    {
        var actual = _3168_MinimumChairs.MinimumChairs(s);
        Assert.Equal(expected, actual);
    }
}
