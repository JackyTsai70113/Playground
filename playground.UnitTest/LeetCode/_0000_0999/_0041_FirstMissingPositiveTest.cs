using playground.LeetCode._0000_0999;

namespace playground.UnitTest.LeetCode._0000_0999;

public class _0041_FirstMissingPositiveTest
{
    [Theory]
    [InlineData("[1,2,0]", 3)]
    [InlineData("[3,4,-1,1]", 2)]
    [InlineData("[7,8,9,11,12]", 1)]
    [InlineData("[1]", 2)]
    public void FirstMissintPositive(string nums, int expected)
    {
        var actual = _0041_FirstMissingPositive.FirstMissingPositive(nums.ToArr());
        Assert.Equal(expected, actual);
    }
}
