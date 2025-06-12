using playground.LeetCode._3000_3999;

namespace playground.UnitTest.LeetCode._3000_3999;

public class _3577_CountPermutationsTest
{
    [Theory]
    [InlineData(new int[] { 1, 2, 3 }, 2)]
    [InlineData(new int[] { 58, 283, 52 }, 0)]
    [InlineData(new int[] { 3, 3, 3, 4, 4, 4 }, 0)]
    public void CountPermutations(int[] A, int expected)
    {
        var actual = _3577_CountPermutations.CountPermutations(A);
        Assert.Equal(expected, actual);
    }
}
