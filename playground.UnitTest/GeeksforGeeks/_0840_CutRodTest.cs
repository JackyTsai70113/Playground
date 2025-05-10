using playground.GeeksforGeeks;

namespace playground.UnitTest.GeeksforGeeks;

public class _0840_CutRodTest
{
    [Theory]
    [InlineData(new int[] { 1, 5, 8, 9, 10, 17, 17, 20 }, 22)]
    [InlineData(new int[] { 1, 5, 8, 9, 10, 17, 17, 10000 }, 10000)]
    public void Test(int[] price, int expected)
    {
        int actual = _0840_CutRod.CutRod_TopDown(price);
        Assert.Equal(expected, actual);

        int actual2 = _0840_CutRod.CutRod_BottomUp(price);
        Assert.Equal(expected, actual2);
    }
}
