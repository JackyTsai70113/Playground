namespace playground.UnitTest;

public class SplitArrayTest0410
{
    [Theory]
    [InlineData("[7,2,5,10,8]", 2, 18)]
    [InlineData("[1,2,3,4,5]", 2, 9)]
    public void SplitArray(string nums, int k, int expected)
    {
        var actual = SplitArray0410.SplitArray(nums.ToArr(), k);
        Assert.Equal(expected, actual);
    }
}
