namespace playground.UnitTest;

public class MinBitFlipsTest2220
{
    [Theory]
    [InlineData(10, 7, 3)]
    [InlineData(3, 4, 3)]
    public void MinBitFlips(int start, int goal, int expected)
    {
        var actual = MinBitFlips2220.MinBitFlips(start, goal);
        Assert.Equal(expected, expected);
    }
}
