namespace playground.UnitTest;

public class MinPatchesTest_0330
{
    [Theory]
    [InlineData("[1,3]", 6, 1)]
    [InlineData("[1,5,10]", 20, 2)]
    [InlineData("[1,2,2]", 5, 0)]
    [InlineData("[1,2,31,33]", 2147483647, 28)]
    public void MinPatches(string nums, int n, int expected)
    {
        var actual = MinPatches_0330.MinPatches(nums.ToArr(), n);
        Assert.Equal(expected, actual);
    }
}
