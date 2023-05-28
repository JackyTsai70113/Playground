using playground.DynamicPrograming;

namespace playground.UnitTest.DynamicPrograming;

public class CountPartitionsTest
{
    [Theory]
    [InlineData(new int[] { 96, 40, 22, 98, 9, 97, 45, 22, 79, 57, 95, 62 }, 505, 0)]
    [InlineData(new int[] { 1, 2, 3, 4 }, 4, 6)]
    [InlineData(new int[] { 3, 3, 3 }, 4, 0)]
    [InlineData(new int[] { 6, 6 }, 2, 2)]
    public void CountPartitions(int[] A, int k, int expected)
    {
        int actual = CountPartitionsClass.CountPartitions(A, k);
        Assert.Equal(expected, actual);
    }
}
