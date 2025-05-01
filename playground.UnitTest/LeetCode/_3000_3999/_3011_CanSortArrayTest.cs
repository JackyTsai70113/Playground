namespace playground.UnitTest;

public class _3011_CanSortArrayTest
{
    [Theory]
    [InlineData("[128,128]", true)]
    [InlineData("[75,34,30]", false)]
    [InlineData("[8,4,2,30,15]", true)]
    [InlineData("[1,2,3,4,5]", true)]
    [InlineData("[3,16,8,4,2]", false)]
    public void CanSortArray(string nums, bool expected)
    {
        var actual = _3011_CanSortArray.CanSortArray(nums.ToArr());
        Assert.Equal(expected, actual);
    }
}
