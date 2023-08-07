using playground.PriorityQueues;

namespace playground.UnitTest.PriorityQueues;

public class MaximumSafenessFactorTest
{
    [Theory]
    [InlineData("[[1,0,0],[0,0,0],[0,0,1]]", 0)]
    [InlineData("[[0,0,1],[0,0,0],[0,0,0]]", 2)]
    [InlineData("[[0,0,0,1],[0,0,0,0],[0,0,0,0],[1,0,0,0]]", 2)]
    [InlineData("[[0,1,1],[0,1,1],[0,1,0]]", 0)]
    public void MaximumSafenessFactor(string nums, int expected)
    {
        var actual = MaximumSafenessFactorClass.MaximumSafenessFactor(nums.To2dArr());
        Assert.Equal(expected, actual);
    }
}
