using playground.LeetCode._2000_2999;

namespace playground.UnitTest.LeetCode._2000_2999;

public class _2997_MinOperationsTest
{
    [Theory]
    [InlineData("[2,1,3,4]", 1, 2)]
    [InlineData("[2,0,2,0]", 0, 0)]
    public void MinOperations(string nums, int k, int expected)
    {
        var actual = _2997_MinOperations.MinOperations(nums.ToArr(), k);
        Assert.Equal(expected, actual);
    }
}
