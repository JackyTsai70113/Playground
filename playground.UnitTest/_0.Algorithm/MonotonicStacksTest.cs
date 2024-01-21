namespace playground.UnitTest._0.Algorithm;

public class MonotonicStacksTest
{
    [Theory]
    [InlineData("[3,1,2,4]", "[-1,-1,1,2]")]
    [InlineData("[11,81,94,43,3]", "[-1,0,1,0,-1]")]
    public void GetPreviousLessIndex(string nums, string expected)
    {
        var actual = MonotonicStacks.GetPreviousLessIndex(nums.ToArr());
        Assert.Equal(expected.ToArr(), actual);
    }

    [Theory]
    [InlineData("[3,1,2,4]", "[1,4,4,4]")]
    [InlineData("[11,81,94,43,3]", "[4,3,3,4,5]")]
    public void GetNextLessIndex(string nums, string expected)
    {
        var actual = MonotonicStacks.GetNextLessIndex(nums.ToArr());
        Assert.Equal(expected.ToArr(), actual);
    }

    [Theory]
    [InlineData("[3,1,2,4]", "[1,4,4,4]")]
    [InlineData("[11,81,94,43,3]", "[4,3,3,4,5]")]
    public void GetNextLessIndex2(string nums, string expected)
    {
        var actual = MonotonicStacks.GetNextLessIndex2(nums.ToArr());
        Assert.Equal(expected.ToArr(), actual);
    }

    [Theory]
    [InlineData("[3,1,2,4]", "[0,0,0,3]")]
    [InlineData("[11,81,94,43,3]", "[0,1,2,2,2]")]
    public void GetBackwardMaxIndex(string nums, string expected)
    {
        var actual = MonotonicStacks.GetBackwardMaxIndex(nums.ToArr());
        Assert.Equal(expected.ToArr(), actual);
    }

    [Theory]
    [InlineData("[3,1,2,4]", "[0,0,0,3]")]
    [InlineData("[11,81,94,43,3]", "[0,1,2,2,2]")]
    public void GetBackwardMaxIndex2(string nums, string expected)
    {
        var actual = MonotonicStacks.GetBackwardMaxIndex2(nums.ToArr());
        Assert.Equal(expected.ToArr(), actual);
    }

    [Theory]
    [InlineData("[3,1,2,4]", "[3,3,3,3]")]
    [InlineData("[11,81,94,43,3]", "[2,2,2,3,4]")]
    public void GetForwardMaxIndex(string nums, string expected)
    {
        var actual = MonotonicStacks.GetForwardMaxIndex(nums.ToArr());
        Assert.Equal(expected.ToArr(), actual);
    }

    [Theory]
    [InlineData("[3,1,2,4]", "[3,3,3,3]")]
    [InlineData("[11,81,94,43,3]", "[2,2,2,3,4]")]
    public void GetForwardMaxIndex2(string nums, string expected)
    {
        var actual = MonotonicStacks.GetForwardMaxIndex2(nums.ToArr());
        Assert.Equal(expected.ToArr(), actual);
    }

    [Theory]
    [InlineData("[1,4,3,7,4,5]", 2, "[1,5]")]
    [InlineData("[1,4,3,7,4,5]", 4, "[3,5]")]
    public void GetLocalMinimalSubarray(string nums, int index, string expected)
    {
        var actual = MonotonicStacks.GetLocalMinimalSubarray(nums.ToArr(), index);
        Assert.Equal(expected.ToArr(), actual);
    }
}
