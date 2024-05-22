namespace playground.UnitTest;

public class SubsetXORSumTest1863
{
    [Theory]
    [InlineData(new int[] { 1, 3 }, 6)]
    [InlineData(new int[] { 5, 1, 6 }, 28)]
    [InlineData(new int[] { 3, 4, 5, 6, 7, 8 }, 480)]
    public void SubsetXORSum(int[] nums, int expected)
    {
        var actual = SubsetXORSum1863.SubsetXORSum(nums);
        Assert.Equal(expected, actual);
    }
}
