using playground.DynamicProgramming;

namespace playground.UnitTest.DynamicProgramming;

public class MinIncrementOperationsTest
{
    [Theory]
    [InlineData(new int[] { 2, 3, 0, 0, 2 }, 4, 3)]
    [InlineData(new int[] { 0, 1, 3, 3 }, 5, 2)]
    [InlineData(new int[] { 1, 1, 2 }, 1, 0)]
    public void MinIncrementOperations(int[] nums, int k, int expected)
    {
        var actual = MinIncrementOperationsClass.MinIncrementOperations(nums, k);
        Assert.Equal(expected, actual);
    }
}
