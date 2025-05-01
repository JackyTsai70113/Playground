using playground.LeetCode._0000_0999;

namespace playground.UnitTest.LeetCode._0000_0999;

public class _0080_RemoveDuplicatesTest
{
    [Theory]
    [InlineData("[9]", "[9]")]
    [InlineData("[1,2]", "[1,2]")]
    [InlineData("[1,1,1,2,2,3]", "[1,1,2,2,3]")]
    [InlineData("[1,1,1,2,2,3,3]", "[1,1,2,2,3,3]")]
    [InlineData("[1,1,1,2,2,3,3,3]", "[1,1,2,2,3,3]")]
    [InlineData("[1,1,1,2,2,3,3,3,3]", "[1,1,2,2,3,3]")]
    [InlineData("[0,0,1,1,1,1,2,3,3]", "[0,0,1,1,2,3,3]")]
    [InlineData("[0,0,1,1,1,1,2,3,3,3]", "[0,0,1,1,2,3,3]")]
    public void RemoveDuplicates(string numsArr, string expectedArr)
    {
        var nums = numsArr.ToArr();
        var idx = _0080_RemoveDuplicates.RemoveDuplicates(nums);
        Assert.Equal(expectedArr.ToArr(), nums.Take(idx));
    }
}
