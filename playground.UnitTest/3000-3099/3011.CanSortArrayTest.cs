namespace playground.UnitTest;

public class CanSortArrayTest3011
{
    [Theory]
    [InlineData("[128,128]", true)]
    [InlineData("[75,34,30]", false)]
    [InlineData("[8,4,2,30,15]", true)]
    [InlineData("[1,2,3,4,5]", true)]
    [InlineData("[3,16,8,4,2]", false)]
    public void CanSortArray(string nums, bool expected)
    {
        var actual = CanSortArray3011.CanSortArray(nums.ToArr());
        Assert.Equal(expected, actual);
    }
}
