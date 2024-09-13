namespace playground.UnitTest;

public class MinAvailableDurationTest1229
{
    [Theory]
    [InlineData("[[10,50],[60,120],[140,210]]", "[[0,15],[60,70]]", 8, new int[] { 60, 68 })]
    [InlineData("[[10,50],[60,120],[140,210]]", "[[0,15],[60,70]]", 12, new int[] { })]
    [InlineData("[[10,60]]", "[[12,17],[21,50]]", 8, new int[] { 21, 29 })]
    [InlineData("[[10,12],[15, 25]]", "[[0,100]]", 8, new int[] { 15, 23 })]
    [InlineData("[[0,100]]", "[[10,12],[15, 25]]", 8, new int[] { 15, 23 })]
    public void JobScheduling(string slots1, string slots2, int duration, int[] expected)
    {
        var actual = MinAvailableDuration1229.MinAvailableDuration(slots1.To2dArr(), slots2.To2dArr(), duration);
        Assert.Equal(expected, actual);
    }
}
