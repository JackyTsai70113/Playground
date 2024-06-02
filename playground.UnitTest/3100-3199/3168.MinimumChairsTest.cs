namespace playground.UnitTest;

public class MinimumChairsTest3168
{
    [Theory]
    [InlineData("EEEEEEE", 7)]
    [InlineData("ELELEEL", 2)]
    [InlineData("ELEELEELLL", 3)]
    public void MinimumChairs(string s, int expected)
    {
        var actual = MinimumChairs3168.MinimumChairs(s);
        Assert.Equal(expected, actual);
    }
}
