namespace playground.UnitTest;

public class _3139_MinCostToEqualizeArrayTest
{
    [Theory]
    [InlineData(new int[] { 4, 1 }, 5, 2, 15)]
    [InlineData(new int[] { 2, 3, 3, 3, 5 }, 2, 1, 6)]
    [InlineData(new int[] { 3, 5, 3 }, 1, 3, 4)]
    [InlineData(new int[] { 1, 14, 14, 15 }, 2, 1, 20)]
    [InlineData(new int[] { 43, 46, 1, 1 }, 41, 5, 271)]
    [InlineData(new int[] { 4, 3, 1, 8 }, 5, 1, 8)]
    [InlineData(new int[] { 60, 19, 53, 31, 57 }, 60, 2, 90)]
    public void MinCostToEqualizeArray(int[] nums, int cost1, int cost2, int expected)
    {
        var actual = _3139_MinCostToEqualizeArray.MinCostToEqualizeArray(nums, cost1, cost2);
        Assert.Equal(expected, actual);
    }
}
