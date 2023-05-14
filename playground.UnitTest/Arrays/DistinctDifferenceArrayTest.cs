using playground.Arrays;
using playground.UnitTest.Utils;

namespace playground.UnitTest.Arrays;

public class DistinctDifferenceArrayTest
{
    [Theory]
    [InlineData("[1,2,3,4,5]", "[-3,-1,1,3,5]")]
    [InlineData("[3,2,3,4,2]", "[-2,-1,0,2,3]")]
    public void DistinctDifferenceArray(string numsStr, string expectedStr)
    {
        var nums = numsStr.ToArr<int>();
        var actual = DistinctDifferenceArrayClass.DistinctDifferenceArray(nums);
        Assert.Equal(expectedStr.ToArr<int>(), actual);
    }
}
