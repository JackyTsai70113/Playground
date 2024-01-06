namespace playground.UnitTest;

public class DistinctDifferenceArrayTest2670
{
    [Theory]
    [InlineData("[1, 2, 3, 4, 5]", "[-3, -1, 1, 3, 5]")]
    [InlineData("[3, 2, 3, 4, 2]", "[-2, -1, 0, 2, 3]")]
    public void DistinctDifferenceArray(string nums, string expected)
    {
        var actual = DistinctDifferenceArray2670.DistinctDifferenceArray(nums.ToArr());
        Assert.Equal(expected.ToArr(), actual);
    }
}
