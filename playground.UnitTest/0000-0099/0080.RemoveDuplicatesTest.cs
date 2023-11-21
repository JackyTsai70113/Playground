namespace playground.UnitTest;

public class RemoveDuplicatesTest_0080
{
    [Theory]
    [InlineData("[9]", 1, "[9]")]
    [InlineData("[1,2]", 2, "[1,2]")]
    [InlineData("[1,1,1,2,2,3]", 5, "[1,1,2,2,3]")]
    [InlineData("[1,1,1,2,2,3,3]", 6, "[1,1,2,2,3,3]")]
    [InlineData("[1,1,1,2,2,3,3,3]", 6, "[1,1,2,2,3,3]")]
    [InlineData("[1,1,1,2,2,3,3,3,3]", 6, "[1,1,2,2,3,3]")]
    [InlineData("[0,0,1,1,1,1,2,3,3]", 7, "[0,0,1,1,2,3,3]")]
    [InlineData("[0,0,1,1,1,1,2,3,3,3]", 7, "[0,0,1,1,2,3,3]")]
    public void RemoveDuplicates(string numsArr, int expected, string expectedArr)
    {
        var nums = numsArr.ToArr();
        var idx = RemoveDuplicates_0080.RemoveDuplicates(nums);
        Assert.Equal(expected, idx);
        Assert.True(Enumerable.SequenceEqual(expectedArr.ToArr(), nums.Take(idx)));
    }
}
