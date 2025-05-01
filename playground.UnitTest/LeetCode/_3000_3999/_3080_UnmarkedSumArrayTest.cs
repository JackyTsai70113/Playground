namespace playground.UnitTest;

public class _3080_UnmarkedSumArrayTest
{
    [Theory]
    [InlineData("[1,2,2,1,2,3,1]", "[[1,2],[3,3],[4,2]]", "[8,3,0]")]
    [InlineData("[1,4,2,3]", "[[0,1]]", "[7]")]
    public void UnmarkedSumArray(string nums, string queries, string expected)
    {
        var actual = _3080_UnmarkedSumArray.UnmarkedSumArray(nums.ToArr(), queries.To2dArr());
        Assert.Equal(expected.ToArr<long>(), actual);
    }
}
