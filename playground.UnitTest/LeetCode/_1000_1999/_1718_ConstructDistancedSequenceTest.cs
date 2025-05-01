using playground._1700_1799;

namespace playground.UnitTest._1700_1799;

public class _1718_ConstructDistancedSequenceTest
{
    [Theory]
    [InlineData(3, new int[] { 3, 1, 2, 3, 2 })]
    [InlineData(5, new int[] { 5, 3, 1, 4, 3, 5, 2, 4, 2 })]
    [InlineData(8, new int[] { 8, 6, 4, 2, 7, 2, 4, 6, 8, 5, 3, 7, 1, 3, 5 })]
    public void ConstructDistancedSequence(int n, int[] expected)
    {
        var actual = _1718_ConstructDistanceSequence_cs.ConstructDistancedSequence(n);
        Assert.Equal(expected, actual);
    }
}
