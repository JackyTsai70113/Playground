namespace playground.UnitTest;

public class SortArrayTest0912
{
    [Theory]
    [InlineData("[5,2,3,1]", "[1,2,3,5]")]
    [InlineData("[9,8,7,6,5,4,3,2,1,0]", "[0,1,2,3,4,5,6,7,8,9]")]
    [InlineData("[9,8,7,6,5,0,1,2,3,4]", "[0,1,2,3,4,5,6,7,8,9]")]
    public void SortArray(string nums, string expected)
    {
        var actual = SortArray0912.SortArray(nums.ToArr());
        Assert.Equal(expected.ToArr(), actual);
    }
}
