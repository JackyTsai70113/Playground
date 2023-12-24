namespace playground.UnitTest;

public class LargestPerimeterTest2971
{
    [Theory]
    [InlineData("[5,5,5]", 15)]
    [InlineData("[1,12,1,2,5,50,3]", 12)]
    [InlineData("[5,5,50]", -1)]
    public void LargestPerimeter(string nums, long expected)
    {
        var actual = LargestPerimeter2971.LargestPerimeter(nums.ToArr());
        Assert.Equal(expected, actual);
    }
}
