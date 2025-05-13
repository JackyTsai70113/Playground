namespace playground.UnitTest.LeetCode._3000_3999;

public class _3232_CanAliceWinTest
{
    [Theory]
    [InlineData(new int[] { 1, 2, 3, 4, 10 }, false)]
    [InlineData(new int[] { 1, 2, 3, 4, 5, 14 }, true)]
    [InlineData(new int[] { 5, 5, 5, 25 }, true)]
    public void CanAliceWin(int[] nums, bool expected)
    {
        var actual = _3232_CanAliceWin.CanAliceWin(nums);
        Assert.Equal(expected, actual);
    }
}
