using playground.LeetCode._0000_0999;

namespace playground.UnitTest.LeetCode._0000_0999;

public class _0877_StoneGameTest
{
    [Theory]
    [InlineData(new int[] { 5, 3, 4, 5
}, true)]
    [InlineData(new int[] { 3, 7, 2, 3 }, true)]
    public void StoneGame(int[] A, bool expected)
    {
        bool actual;
        actual = _0877_StoneGame.StoneGame_TopDown(A);
        Assert.Equal(expected, actual);
        actual = _0877_StoneGame.StoneGame_BottomUp(A);
        Assert.Equal(expected, actual);
        actual = _0877_StoneGame.StoneGame_OptimizeSpace(A);
        Assert.Equal(expected, actual);
    }
}
