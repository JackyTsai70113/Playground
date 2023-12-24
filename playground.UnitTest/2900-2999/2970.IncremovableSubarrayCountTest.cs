namespace playground.UnitTest;

public class IncremovableSubarrayCountTest2970
{
    [Theory]
    [InlineData("[1,2,3,4]", 10)]
    [InlineData("[6,5,7,8]", 7)]
    [InlineData("[8,7,6,6]", 3)]
    public void IncremovableSubarrayCount(string nums, int expected)
    {
        var actual = IncremovableSubarrayCount2970.IncremovableSubarrayCount(nums.ToArr());
        Assert.Equal(expected, actual);
    }
}
