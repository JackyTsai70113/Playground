using playground.LeetCode._2000_2999;

namespace playground.UnitTest.LeetCode._2000_2999;

public class _2410_MatchPlayersAndTrainersTest
{
    [Theory]
    [InlineData(new int[] { 4, 7, 9 }, new int[] { 8, 2, 5, 8 }, 2)]
    [InlineData(new int[] { 1, 1, 1 }, new int[] { 10 }, 1)]
    [InlineData(new int[] { 1, 1000000000 }, new int[] { 1000000000, 1 }, 2)]
    [InlineData(new int[] { 2, 1 }, new int[] { 2, 2 }, 2)]
    public void MatchPlayersAndTrainers(int[] A, int[] B, int expected)
    {
        var actual = _2410_MatchPlayersAndTrainers.MatchPlayersAndTrainers(A, B);
        Assert.Equal(expected, actual);
    }
}
