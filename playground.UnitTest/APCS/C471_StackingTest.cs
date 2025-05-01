using playground.APCS;

namespace playground.UnitTest.APCS;

public class C471_StackingTest
{
    [Theory]
    [InlineData(2, new int[] { 20, 10 }, new int[] { 1, 1 }, 10)]
    [InlineData(2, new int[] { 1, 2 }, new int[] { 3, 4 }, 4)]
    [InlineData(3, new int[] { 3, 4, 5 }, new int[] { 1, 2, 3 }, 19)]
    public void Stacking(int n, int[] weights, int[] times, long expected)
    {
        var actual = C471_Stacking.Stacking(n, weights, times);
        Assert.Equal(expected, actual);
    }
}
