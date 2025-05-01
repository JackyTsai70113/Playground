using playground.LeetCode._2000_2999;

namespace playground.UnitTest.LeetCode._2000_2999;

public class _2971_LargestPerimeterTest
{
    [Theory]
    [InlineData("[5,5,5]", 15)]
    [InlineData("[1,12,1,2,5,50,3]", 12)]
    [InlineData("[5,5,50]", -1)]
    public void LargestPerimeter(string nums, long expected)
    {
        var actual = _2971_LargestPerimeter.LargestPerimeter(nums.ToArr());
        Assert.Equal(expected, actual);
    }
}
