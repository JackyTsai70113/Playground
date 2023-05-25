using playground.SlidingWindow;

namespace playground.UnitTest.SlidingWindow;

public class FindPairsTest
{
    [Theory]
    [InlineData("[3,1,4,1,5]", 2, 2)]
    [InlineData("[1,2,3,4,5]", 1, 4)]
    [InlineData("[1,3,1,5,4]", 0, 1)]
    [InlineData("[6,7,3,6,4,6,3,5,6,9]", 4, 2)]
    public void FindPairs(string nums, int k, int expected){
        var actual = FindPairsClass.FindPairs(nums.ToArr<int>(), k);
        Assert.Equal(expected, actual);
    }
}
