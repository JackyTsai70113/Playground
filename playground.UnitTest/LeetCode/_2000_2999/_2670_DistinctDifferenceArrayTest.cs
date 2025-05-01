using playground.LeetCode._2000_2999;

namespace playground.UnitTest.LeetCode._2000_2999;

public class _2670_DistinctDifferenceArrayTest
{
    [Theory]
    [InlineData("[1, 2, 3, 4, 5]", "[-3, -1, 1, 3, 5]")]
    [InlineData("[3, 2, 3, 4, 2]", "[-2, -1, 0, 2, 3]")]
    public void DistinctDifferenceArray(string nums, string expected)
    {
        var actual = _2670_DistinctDifferenceArray.DistinctDifferenceArray(nums.ToArr());
        Assert.Equal(expected.ToArr(), actual);
    }
}
