namespace playground.UnitTest;

public class SubarraysWithKDistinctTest0992
{
    [Theory]
    [InlineData("[1,2,1,2,3]", 2, 7)]
    [InlineData("[1,2,1,3,4]", 3, 3)]
    public void SubarraysWithKDistinct(string nums, int k, int expected)
    {
        var actual = SubarraysWithKDistinct0992.SubarraysWithKDistinct(nums.ToArr(), k);
        Assert.Equal(expected, actual);
    }
}
