namespace playground.UnitTest;

public class LemonadeChangeTest860
{
    [Theory]
    [InlineData(new int[] { 5, 5, 5, 20 }, true)]
    [InlineData(new int[] { 10, 5, 5, 10, 20 }, false)]
    [InlineData(new int[] { 5, 5, 5, 10, 20 }, true)]
    [InlineData(new int[] { 5, 5, 10, 10, 20 }, false)]
    public void MinFlips(int[] bills, bool expected)
    {
        var actual = LemonadeChange860.LemonadeChange(bills);
        Assert.Equal(expected, actual);
    }
}
