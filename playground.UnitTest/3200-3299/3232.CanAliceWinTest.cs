namespace playground.UnitTest;

public class CanAliceWinTest3232
{
    [Theory]
    [InlineData(new int[] { 1, 2, 3, 4, 10 }, false)]
    [InlineData(new int[] { 1, 2, 3, 4, 5, 14 }, true)]
    [InlineData(new int[] { 5, 5, 5, 25 }, true)]
    public void CanAliceWin(int[] nums, bool expected)
    {
        var actual = CanAliceWin3232.CanAliceWin(nums);
        Assert.Equal(expected, actual);
    }
}
