using playground.DynamicPrograming;

namespace playground.UnitTest.DynamicPrograming;

public class MaxScoreTest
{
    [Theory]
    [InlineData(new int[] { 1, 2 }, 1)]
    [InlineData(new int[] { 3, 4, 6, 8 }, 11)]
    [InlineData(new int[] { 1, 2, 3, 4, 5, 6 }, 14)]
    public void MaxScore(int[] A, int expected)
    {
        int actual = MaxScoreClass.MaxScore(A);

        Assert.Equal(expected, actual);
    }
}
